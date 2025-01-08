Screen Sound 2.0

Descrição do Projeto

O Screen Sound 2.0 é uma aplicação em C# desenvolvida para gerenciamento de bandas e álbuns musicais.
O sistema permite registrar bandas, álbuns, avaliar bandas e álbuns, e exibir detalhes sobre as bandas. Além disso, utiliza a API do ChatGPT para gerar automaticamente um resumo sobre cada nova banda registrada, proporcionando uma experiência mais rica para o usuário.

Funcionalidades

Registrar uma banda

Registrar um álbum para uma banda

Mostrar todas as bandas registradas

Avaliar uma banda

Avaliar um álbum

Exibir os detalhes de uma banda

Integração com API do ChatGPT para gerar descrições automáticas de novas bandas

Dependências

Para que o projeto funcione corretamente, o desenvolvedor deve garantir:

Classe ApiKey: Ao importar o projeto, crie uma classe chamada ApiKey, que deve conter o seguinte:

internal class ApiKey
{
    public static string GetKey()
    {
        return "sua-chave-valida-aqui";
    }
}

Substitua "sua-chave-valida-aqui" pela sua chave de API do ChatGPT.

Chave válida da API do ChatGPT: A aplicação requer uma chave ativa para acessar os serviços da API. Obtenha sua chave no site oficial do OpenAI.

Estrutura do Projeto

ScreenSound.Menus: Contém os menus do sistema que implementam as funcionalidades descritas.

ScreenSound.Modelos: Modelos utilizados para representar bandas, álbuns e avaliações.
