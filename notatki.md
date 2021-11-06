# 1. Wiadomości wstępne ASP.core 5.0
## 1.1 Historia asp..
### Strony: Active Server Pages asp
### asp.net Web.Forms posiadały stan przesyłany jako ukryte pole formularza między serwerem i stroną .asp .aspx
### młodzi gniewni open source MVC asp.net
### Utworzenie wersji core bez naleciałości windows asp.net core   1....  3.1
### Wersja z obsługą aplikacji desktopowych .NET 5.0   .. .NET 6.0 ...
## 1.2 Dokumentacja i zasoby:
https://dotnet.microsoft.com/ zasoby

https://docs.microsoft.com/pl-pl/aspnet/core/?WT.mc_id=dotnet-35129-website&view=aspnetcore-5.0  dokumentacja polska (UWAGA)

https://docs.microsoft.com/en-us/aspnet/core/?WT.mc_id=dotnet-35129-website&view=aspnetcore-5.0    dokumentacja angielska

## 1.3 dotnet
```console
dotnet --version
dotnet --help
dotnet --list-sdks
dotnet --list-runtimes
dotnet new --help 
```

Certyfiktay dla przeglądarki:
```cons
dotnet dev-certs https --trust
```
Lista możliwych templates:

```console
dotnet new -l
dotnet new web -o cw1 //--pusta aplikacja web
dotnet run // -- kompilacja i uruchomienie
dotnet new page -n Index
```
### Dodanie obsługi plików statycznych oraz RazorPages w pliku startup.cs

```csharp
 public void ConfigureServices(IServiceCollection services)
{
    services.AddRazorPages();
}
...

app.UseStaticFiles();
app.UseEndpoints(endpoints =>
{
    // endpoints.MapGet("/", async context =>
    // {
    //     await context.Response.WriteAsync("Hello World!");
    // });
    // endpoints.MapGet("/nowe",async context => {
    //     await context.Response.WriteAsync("nowy adres i to coś nowego");
    // });
    endpoints.MapRazorPages();
});
```
### Załadowanie _viewimports
```console
    dotnet new viewimports  // dodajemy importy do projektu aby korzystać np z tag-helperów
```


