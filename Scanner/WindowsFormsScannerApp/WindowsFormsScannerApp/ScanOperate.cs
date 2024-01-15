using System;
using System.IO;
using System.Net.Sockets;
using System.Text;

class ScannerNetworkIntegration
{
    static void Main()
    {
        // 스캐너의 IP 주소와 포트 번호
        string scannerIpAddress = "192.168.1.100";
        int scannerPort = 12345;

        try
        {
            // 스캐너에 연결
            using (TcpClient client = new TcpClient(scannerIpAddress, scannerPort))
            using (NetworkStream stream = client.GetStream())
            {
                // 스캐너에 스캔 명령 전송
                string scanCommand = "SCAN";
                byte[] data = Encoding.UTF8.GetBytes(scanCommand);
                stream.Write(data, 0, data.Length);

                Console.WriteLine("스캔 명령을 스캐너에 전송했습니다.");

                // 이미지 데이터 수신
                byte[] buffer = new byte[1024];
                using (MemoryStream imageStream = new MemoryStream())
                {
                    int bytesRead;
                    while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        imageStream.Write(buffer, 0, bytesRead);
                    }

                    // 이미지 저장
                    File.WriteAllBytes("scanned_image.jpg", imageStream.ToArray());
                    Console.WriteLine("이미지가 성공적으로 저장되었습니다.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"오류: {ex.Message}");
        }
    }
}
