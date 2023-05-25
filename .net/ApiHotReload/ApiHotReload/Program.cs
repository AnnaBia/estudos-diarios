// classe respons�vel pelas configura��es do servi�o

var builder = WebApplication.CreateBuilder(args); // WebApplication unifica os recursos de host, por isso n�o h� namespace ou main, o compilador fica respons�vel


builder.Services.AddControllers(); // servi�os para usar as controllers
builder.Services.AddEndpointsApiExplorer(); // configura o servi�o do swagger
builder.Services.AddSwaggerGen();

var app = builder.Build(); // buildando o servi�o de webapplication

if (app.Environment.IsDevelopment()) // verifica se est� em ambiente de desenvolvimento, se positivo registra os middleware do swagger
{
    // middleware * manipula as solicita��es e respostas
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); // incluindo os middleware para redirecionar para o https

app.UseAuthorization(); // incluindo middleware para autoriza��o

app.MapControllers(); // incluindo middleware para as actions dos controladores

app.Run(); // executa a aplica��o