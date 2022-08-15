// POST�� �����͸� �ۼ��Ѵ�.

StringBuilder postParams = new StringBuilder();
postParams.Append("TEST1 = test1");
postParams.Append("&TEST2 = test2");



// Encoding

Encoding encoding = Encoding.UTF8;

byte[] result = encoding.GetBytes(postParams.ToString());



// Ÿ���� �Ǵ� �������� URL
string Url = "http://test.net"

// HttpWebRequest ������Ʈ ����
HttpWebRequest wReqFirst = (HttpWebRequest)WebRequest.Create(Url);



// HttpWebRequest ������Ʈ ����
wReqFirst.Method = "POST";
wReqFirst.ContentType = "application/x-www-form-urlencoded";
wReqFirst.ContentLength = result.Length;



// POST�� �����͸� �Է��մϴ�.

Stream postDataStream = wReqFirst.GetRequestStream();
postDataStream.Write(result, 0, result.Length);
postDataStream.Close();



// HttpWebRequest������Ʈ�� ���� HttpWebResponse������Ʈ�� �����մϴ�.

// HttpWebRequest������Ʈ�� ������ ���� ��� �̺κп��� Exception�� �߻��մϴ�.

// Ȯ���� �صα� ���ؼ��� try-catch�� �ڵ鸵 ���� �ʿ䰡 �ֽ��ϴ�.

HttpWebResponse wRespFirst = (HttpWebResponse)wReqFirst.GetResponse();



// Response�� ����� ��Ʈ���� �����մϴ�.
Stream respPostStream = wRespFirst.GetResponseStream();
StreamReader readerPost = new StreamReader(respPostStream, Encoding.Default);



// ������ ��Ʈ�����κ��� string���� ��ȯ�մϴ�.

string resultPost = readerPost.ReadToEnd();





//Get��� ������ �Է�

StringBuilder getParams = new StringBuilder();

getParams.Append("arg1=" + arg1);

getParams.Append("&arg2=" + arg2);

getParams.Append("&arg3=" + arg3);



// �ѱۺκи� UTF-8 ���ڵ� (�ѱ��� ������)

// ���� �ߴ� �κп��� ��¥ ������ ���ڵ��ϸ� ������ �߻��Ǵ°� ���Ƽ� �ѱۺκи� ���� ���ڵ�

string url = System.Web.HttpUtility.UrlEncode(ErrDesc, System.Text.Encoding.GetEncoding("euc-kr"));



//�ּҺκп� �� �ְ� ��ü ����

HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://test.net/Interface/Page.aspx?" + getParams + url);

myReq.Method = "GET"; // �ʿ� ���µ�?



//HttpWebResponse ��ü �޾ƿ�

HttpWebResponse wRes = (HttpWebResponse)myReq.GetResponse();



// Response�� ����� ��Ʈ���� �����մϴ�.

Stream respGetStream = wRes.GetResponseStream();

StreamReader readerGet = new StreamReader(respGetStream, Encoding.UTF8);



// ������ ��Ʈ�����κ��� string���� ��ȯ�մϴ�.

string resultGet = readerGet.ReadToEnd();



// ��Ʈ������ ��ȯ�� ����Ÿ�� ���������� �ҽ��� �˴ϴ�. �� �����Ϳ���

// �ϰ����ϴ� Ȯ�� �۾��Ǵ� ��� �۾����� �ϸ� �˴ϴ�.


// ��ó 
// https://m.blog.naver.com/PostView.naver?isHttpsRedirect=true&blogId=nawoo&logNo=80135029914