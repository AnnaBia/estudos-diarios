// classe responsável pelas configurações do serviço

var builder = WebApplication.CreateBuilder(args); // WebApplication unifica os recursos de host, por isso não há namespace ou main, o compilador fica responsável


builder.Services.AddControllers(); // serviços para usar as controllers
builder.Services.AddEndpointsApiExplorer(); // configura o serviço do swagger
builder.Services.AddSwaggerGen();

var app = builder.Build(); // buildando o serviço de webapplication

if (app.Environment.IsDevelopment()) // verifica se está em ambiente de desenvolvimento, se positivo registra os middleware do swagger
{
    // middleware * manipula as solicitações e respostas
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection(); // incluindo os middleware para redirecionar para o https

app.UseAuthorization(); // incluindo middleware para autorização

app.MapControllers(); // incluindo middleware para as actions dos controladores

app.Run(); // executa a aplicação