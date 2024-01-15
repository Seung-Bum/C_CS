using System;
using System.IO;
using System.Net;
using System.Text;

class Program
{
    static void Main()
    {
        // OCRSpace API 키
        string apiKey = "YOUR_OCRSPACE_API_KEY";

        // 이미지 파일 경로
        string imagePath = "path/to/your/image.png";

        // OCR 요청 보내기
        string result = PerformOCR(apiKey, imagePath);

        // 결과 출력
        Console.WriteLine("OCR Result:");
        Console.WriteLine(result);
    }

    static string PerformOCR(string apiKey, string imagePath)
    {
        try
        {
            // OCRSpace API 엔드포인트 URL
            string apiUrl = "https://api.ocr.space/parse/image";

            // HTTP 요청을 생성
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(apiUrl);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            // POST 데이터 구성
            string postData = $"apikey={apiKey}&url={imagePath}";
            byte[] data = Encoding.UTF8.GetBytes(postData);

            // 요청 데이터 전송
            using (Stream requestStream = request.GetRequestStream())
            {
                requestStream.Write(data, 0, data.Length);
            }

            // 응답 받기
            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                // 응답 데이터 읽기
                using (Stream responseStream = response.GetResponseStream())
                {
                    using (StreamReader reader = new StreamReader(responseStream))
                    {
                        return reader.ReadToEnd();
                    }
                }
            }
        }
        catch (Exception ex)
        {
            return $"Error: {ex.Message}";
        }
    }
}
