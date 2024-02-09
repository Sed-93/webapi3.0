[![Build an push to AWS](https://github.com/Sed-93/webapi3.0/actions/workflows/YAMLFile.yml/badge.svg)](https://github.com/Sed-93/webapi3.0/actions/workflows/YAMLFile.yml) ![GitHub language count](https://img.shields.io/github/languages/count/sed-93/webapi3.0) ![GitHub commit activity](https://img.shields.io/github/commit-activity/t/sed-93/webapi3.0)

# Webbapplikation för Kryptering och Avkryptering

## Översikt

Detta projekt, `webapi3.0`, är en .NET Core-applikation som tillhandahåller en tjänst för att kryptera och avkryptera text med hjälp av ett modifierat Cesarchiffer. Applikationen är tillgänglig via två endpoints.

## Körning och Testning Lokalt

För att köra och testa applikationen på din lokala maskin, följ dessa steg:

1. Öppna terminalen och navigera till projektets rotmapp:

    ```bash
    cd webapi3.0
    ```

2. Klona GitHub-repot:

    ```bash
    git clone https://github.com/Sed-93/webapi3.0.git
    ```

3. Öppna projektet i din favorit C#-utvecklingsmiljö, till exempel Visual Studio eller VS Code.
4. Bygg projektet med kommandot:

    ```bash
    dotnet build
    ```

5. Starta applikationen med kommandot:

    ```bash
    dotnet run
    ```

När applikationen körs, startas en lokal webbserver. Du kan interagera med applikationen genom att besöka följande endpoints i din webbläsare: `http://localhost:5000/encrypt/{dinText}/{shift}` för kryptering och `http://localhost:5000/decrypt/{dinText}/{shift}` för avkryptering.

6. Kör enhetstesterna med kommandot:

    ```bash
    dotnet test
    ```

Kontrollera resultaten av enhetstesterna för att verifiera att all funktionalitet fungerar som förväntat.

## Enhetstester

Applikationen inkluderar en uppsättning enhetstester som använder xUnit-testramverket. Dessa tester validerar krypteringsfunktionaliteten.

## Tillgång till Applikationen

När applikationen har distribuerats till AWS Elastic Beanstalk, kan du interagera med den genom att besöka följande URL: `http://awsapi-env.eba-pqhkvtmb.eu-north-1.elasticbeanstalk.com/`. Ingen inloggning krävs för att använda applikationen.

För att använda applikationen, navigera till följande endpoints i din webbläsare:

- För att kryptera text, använd: `http://awsapi-env.eba-pqhkvtmb.eu-north-1.elasticbeanstalk.com/encrypt/{dinText}/{shift}`, ersätt `{dinText}` med texten du vill kryptera och `{shift}` med antalet positioner du vill skifta i alfabetet.
- För att avkryptera text, använd: `http://awsapi-env.eba-pqhkvtmb.eu-north-1.elasticbeanstalk.com/decrypt/{dinText}/{shift}`, ersätt `{dinText}` med texten du vill avkryptera och `{shift}` med antalet positioner du vill skifta i alfabetet.
