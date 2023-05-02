Como funciona a **WEB**?
WEB: rede
Uma maneira de trocar informações entre computadores


Exemplo de um caminho simples:


Você digita a URL <https://fonts.google.com/> :


- Protocolo HTTP: Hypertext Transfer Protocol, conjunto de regras que possui como função trocar mensagens entre computadores, essa mensagem será enviada a um computador em diversos pedaços que chamamos de "chunks"
- URL: Uniform Resource Locator, localizador e identificador de recursos, nesse caso o site
  - E iniciada uma linha de comunicação, através do protocolo TCP, entre o seu computador (cliente) até o computador que tem a página (servidor)
- Cliente: O computador, dispositivo ou aplicativo que fez o pedido (ex: browser)
- Servidor: Computador configurado para receber os pedidos e enviar respostas aos pedidos
- TCP: Transmission Control Protocol, outro conjunto de regras, que garante a chegada dos pacotinhos ao destino
  - O endereço é convertido em um IP(76.76.2121) através do DNS
- IP: Internet Protocol, um conjunto de regras para a comunicação do endereço (o computador que fez a solicitação, pois todos os dispositivos possuem seu próprio IP)
- DNS: Domain Name Servers, converte um Domínio (nesse caso a URL) em um endereço de IP
- Seu pedido está percorrendo diversos proxies:
  - Proxy:
    - Qualquer dispositivo no meio do caminho entre o browser(cliente) e o servidor
    Exemplos: Modem, Roteador, outros computadores - Função: Encaminhamento dos pacotes
- Seu pedido chega até o servidor
  - Servidor analisa seu pedido e te dá uma resposta, neste caso, posisitva
- O caminho de volta é semelhante ao de ida, passando pela linha de comunicação que foi criada
- O browser recebe os pedaçõs e mostra a tela do site pra você
  - Esse processo acontece muitas vezes, pois para cada recurso (html, css, javascript, imagem ...) é feita uma nova conexão
  - Esse processo acontece diversas vezes, por que cada uma das coisas, como a parte bonita do HTML ou CSS é um processo diferente, então é feito para cada um deles.
