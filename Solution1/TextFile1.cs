// POST할 데이터를 작성한다.

StringBuilder postParams = new StringBuilder();
postParams.Append("TEST1 = test1");
postParams.Append("&TEST2 = test2");



// Encoding

Encoding encoding = Encoding.UTF8;

byte[] result = encoding.GetBytes(postParams.ToString());



// 타겟이 되는 웹페이지 URL
string Url = "http://test.net"

// HttpWebRequest 오브젝트 생성
HttpWebRequest wReqFirst = (HttpWebRequest)WebRequest.Create(Url);



// HttpWebRequest 오브젝트 설정
wReqFirst.Method = "POST";
wReqFirst.ContentType = "application/x-www-form-urlencoded";
wReqFirst.ContentLength = result.Length;



// POST할 데이터를 입력합니다.

Stream postDataStream = wReqFirst.GetRequestStream();
postDataStream.Write(result, 0, result.Length);
postDataStream.Close();



// HttpWebRequest오브젝트로 부터 HttpWebResponse오브젝트를 생성합니다.

// HttpWebRequest오브젝트에 문제가 있을 경우 이부분에서 Exception이 발생합니다.

// 확실히 해두기 위해서는 try-catch로 핸들링 해줄 필요가 있습니다.

HttpWebResponse wRespFirst = (HttpWebResponse)wReqFirst.GetResponse();



// Response의 결과를 스트림을 생성합니다.
Stream respPostStream = wRespFirst.GetResponseStream();
StreamReader readerPost = new StreamReader(respPostStream, Encoding.Default);



// 생성한 스트림으로부터 string으로 변환합니다.

string resultPost = readerPost.ReadToEnd();





//Get방식 데이터 입력

StringBuilder getParams = new StringBuilder();

getParams.Append("arg1=" + arg1);

getParams.Append("&arg2=" + arg2);

getParams.Append("&arg3=" + arg3);



// 한글부분만 UTF-8 인코딩 (한글이 깨지면)

// 내가 했던 부분에선 날짜 형식을 인코딩하면 문제가 발생되는거 같아서 한글부분만 따로 인코딩

string url = System.Web.HttpUtility.UrlEncode(ErrDesc, System.Text.Encoding.GetEncoding("euc-kr"));



//주소부분에 다 넣고 객체 생성

HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://test.net/Interface/Page.aspx?" + getParams + url);

myReq.Method = "GET"; // 필요 없는듯?



//HttpWebResponse 객체 받아옴

HttpWebResponse wRes = (HttpWebResponse)myReq.GetResponse();



// Response의 결과를 스트림을 생성합니다.

Stream respGetStream = wRes.GetResponseStream();

StreamReader readerGet = new StreamReader(respGetStream, Encoding.UTF8);



// 생성한 스트림으로부터 string으로 변환합니다.

string resultGet = readerGet.ReadToEnd();



// 스트링으로 변환된 데이타는 웹페이지의 소스가 됩니다. 그 데이터에서

// 하고자하는 확인 작업또는 취득 작업등을 하면 됩니다.


// 출처 
// https://m.blog.naver.com/PostView.naver?isHttpsRedirect=true&blogId=nawoo&logNo=80135029914