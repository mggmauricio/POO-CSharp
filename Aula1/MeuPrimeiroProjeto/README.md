# Aula 1: Conceitos básicos

### Criando nosso primeiro projeto C#

#### Crie o projeto:
```bash
dotnet new console -o MeuPrimeiroProjeto
```
#### Entre no projeto
```bash
cd MeuPrimeiroProjeto
``` 
#### Rode o primeiro projeto
```bash
dotnet run
```

### Clique no link acima do código para ver o código completo

```c#
using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
```
  Ao rodar o programa você verá na tela o Hello World que aparece graças ao comando Console.WriteLine("Hello World");
## Usando o debugger do vscode
Para utilizar o debugger do vscode basta apertar *F5* e o programa rodará juntamente com o debug.
