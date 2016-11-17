## Userfull commands 

$ dotnet build 
$ dotnet run 

$ dotnet ef migrations add "name of the migration"
$ dotnet ef database update


## Security 

Web API security 

https://stormpath.com/blog/token-authentication-asp-net-core
https://github.com/nbarbettini/SimpleTokenProvider


## API Usage

baseurl = ""
### Registration
[POST] https://{baseurl}/api/useraccount/register
{"email" : "test@test.com","password":"Qwer$#@!123",confirmpassword:"Qwer$#@!123"}

//note that the password need to have the standard complexity requirements. length > 6 , Numeric, Both Upper and lowercase letters , special chars

### Login
[POST] https://{baseurl}/api/token
x-www-form-urlencoded

"username" = "test@test.com"
"password" = "Qwer$#@!123"


For all subsequent requests the following two headers need to be used

Content-Type = "application/json"
Authorization = Bearer token-received-from-login-request

### Stream

[POST] https://{baseurl}/api/stream/create
 - creates a stream with wowza and returns a json with all the information related to new stream

[GET] https://{baseurl}/api/stream/r1231998 
 - r1231998 is the streamId returned from create call

[POSt] https://{baseurl}/api/stream/start/r1231998 
 - initiates a start call to wowza