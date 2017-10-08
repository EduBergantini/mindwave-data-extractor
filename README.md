# Mindwave Data Extractor
Esse projeto tem como função analisar o comportamento do [Neurosky Mindwave](http://neurosky.com/biosensors/eeg-sensor/)
por padrão as informações obtidas são extraidas no formato de **txt** e no formato **csv** para analises históricas

# Pré requisitos
* [Neurosky Mindwave Mobile](http://neurosky.com/biosensors/eeg-sensor/)
* [.Net Framework 4.5+](https://www.microsoft.com/en-us/download/details.aspx?id=30653)
* Opcional: [Arduino Uno ou Mega 2560](https://store.arduino.cc/usa/)

# Forma de Uso
## Código C#
* Pareie seu Mindwave com o computador
* Abra a aplicação, escolha a porta COM que o Mindwave está comunicando em seguida clique em conectar
* Os arquivos de log criados assim que for conectados e as informações de log serão sincronizadas assim que a aplicação for fechada

## Arduino
* Pareie o Mindwave com o Arduino
* Compile, para o Arduino, um código que escreva para a porta serial as informações capturadas do Mindwave separadas por virgula(,). Vide [Minduino](https://github.com/EduBergantini/minduino)
* Execute a aplicação Mindwave Data Extractor
* Vá para a aba Arduino
* Selecione a porta COM que o Arduino está se comunicando no computador em seguida clique em conectar
* Os arquivos de log criados assim que for conectados e as informações de log serão sincronizadas assim que a aplicação for fechada
 
