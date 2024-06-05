# SpaceCalc 📌

A SpaceCalc é uma solução open source ([Contribuições](#contribuições)) voltada para pequenos comércios, negócios locais e varejistas, oferecendo recursos essenciais de gestão para setores comerciais e industriais. Além disso, o sistema inclui uma robusta administração de regras e permissões, possibilitando a designação de um super usuário para cada implementação do sistema.

Este software utiliza do banco de dados MongoDB, mas estamos planejando disponibilizar suporte para SQL Server em futuras atualizações. Todas as tabelas e estruturas de banco de dados estão detalhadamente documentadas na seção de [Implementação](#implementação), para facilitar o entendimento e a integração.

## Versões
O SpaceCalc oferece duas versões que se distinguem pela simplicidade e funcionalidades do software:

### SpaceCalc - PRO (Gratuito) 🔷

- Garante a implementação de regras e segurança do sistema, proporcionando tranquilidade aos usuários.
- Permite a criação e gerenciamento de usuários com diferentes níveis de acesso, promovendo controle e personalização.

### SpaceCalc - Tool (Gratuito)🔹
- Focado na simplicidade para realizar tarefas de forma eficiente, agilizando o fluxo de trabalho.
- Acessível a qualquer membro da equipe sem a necessidade de criar usuários individuais, o que simplifica o uso e colaboração.
  
---

# Implementação 

Atualmente, não há um método de implementação com suporte disponível. Para integrar o sistema, por favor, entre em contato com um dos nossos colaboradores do software SpaceCalc.

---

# Contribuições

Estamos felizes em receber contribuições da comunidade para melhorar este projeto. Há várias maneiras de contribuir, desde a correção de bugs até o desenvolvimento de novos recursos. Antes de começar, por favor, leia as seguintes diretrizes:

## Como Contribuir 💁

1. **Encontrou um bug?** 

   - Antes de reportar, verifique se o bug já foi relatado. Se ainda não foi, abra uma nova issue descrevendo o problema e como reproduzi-lo.

2. **Deseja implementar uma nova funcionalidade?**

   - Abra uma nova issue explicando a funcionalidade desejada e discuta sua proposta com os mantenedores do projeto.

3. **Tem outra ideia?**

   - Fique à vontade para propor novas ideias ou melhorias. Abra uma issue para iniciar a discussão.

## Contribuições por códigos

Para começar vamos realizar procedimentos para que tudo ocorra dentro dos padrões de SpaceCalc:

   - Faça um fork deste repositório /ou qual deseja fazer atualização (vPRO ou vTool).
   - Crie uma nova branch para sua contribuição: `git checkout -b minha-contribuicao`

Infelizmente não disponibilizamos um MongoDB para testes, mas abaixo está o passo passo para inserir seu DB em nosso software:

1. **Criar um DB no site da Mongo**

   - Acesse o link: https://www.mongodb.com/
   - Crie uma conta caso necessário
   - Em MongoDB Atlas crie sua Cluster para armazenar os dados de SpaceCalc

2. **Configurando arquivo config.xml**

   - Abra o arquivo 'config.xml' dentro da debug na raiz do projeto.
   - Edite em um bloco de notas ou em um editor de textos.
     ```xml
     <?xml version="1.0" encoding="utf-8" ?>
      <Configuracao>
        <MongoDB>
          <username>"username"</username>
          <password>"senha"</password>
          <databasename>"nomedobanco"</databasename>
          <authsource>admin</authsource>
        </MongoDB>
      </Configuracao>
     ```
   - Mude o necessário para que busque o banco criado em MongoDB
   - Após isso mude a string de conexão dentro da classe `mongoDB`
   - Exemplo:
     ```csharp
      string connectionString = $"mongodb+srv://{username}:{password}@spacecalc.wwq39bs.mongodb.net/?retryWrites=true&w=majority&appName=spacecalc";
     ```

     ![image](https://github.com/JeanPasquini/SpaceCalc/assets/126198701/3152d4e4-7815-4074-8b12-f38748e7bc7b)
     `Local: MongoClient GetClient()` Classe - mongoDB

3. **Criando tabelas no MongoDB**
    
   - Abra a query na pasta raiz do projeto para realizar a criação das tabelas (mongoDB.js)
   - Execute o Script usando `mongosh` e visualize no Compass
   - Exemplo caso usuário deseje criar sua própria coleção:
     ```js
      use 'meuBancoDeDados';
      
      db.createCollection("ZUSUARIO");
     ```
     
    3.1. **Alternativa de criação de tabelas no MongoDB**

     - Abra no Mongo seu banco de dados e acesse a área de coleções
     - Crie todas tabelas existentes dentro do script contido no projeto (mongoDB.js)

    3.2. **Usuário administrador**

     - Crie um super usuário para logar durante os testes de seu desenvolvimento.
       ```js
         use 'meuBancoDeDados'
         db.minhaColecao.insertMany([
              {
                  USUARIO: "user",
                  SENHA: "1234",
                  NOMECOMPLETO: "seunomecompleto",
                  EMAIL: "seuemail@hotmail.com",
                  IDSETOR: "1"
              }
         ]);
       ```

4. **Utilize da classe mongoDB**

   - A classe `mongoDB` agiliza os processos CRUD `(create / read / update / delete)`
   - Qualquer alteração nesses processos requer uma explicação clara e com exemplos no projeto.

5. **Postagem PR (Pull Request)**
   
   - Após terminar suas alterações e commit: `git commit -am 'Adicionei uma nova funcionalidade'`
   - Faça push para a branch: `git push origin minha-contribuicao`
   - Envie um pull request descrevendo suas alterações e aguarde o feedback.

6. **Medidas**
   
   - OBSERVAÇÃO: DETALHES NUNCA SÃO DEMAIS, ENRIQUEÇA O PULL REQUEST PARA QUE SEJA FUTURAMENTE EMERGIADO.
   - NOTAS: SEMPRE OBSERVE SE JÁ NÃO EXISTE ALGUMA ATUALIZAÇÃO RELACIONADO AO SEU DESENVOLVIMENTO.
   - REGRAS: CRIE EXEMPLOS (ATÉ 2) QUE FAÇAM USO DE SUA INTEGRAÇÃO, SE POSSÍVEL GRAVAR UM VÍDEO E DEIXAR NO REPOSITÓRIO PARA ANÁLISE DOS CONTRIBUIDORES.

---

# Recursos 📚

SpaceCalc expressa sua gratidão pelas bibliotecas vizinhas, que desempenham um papel essencial na administração e otimização de parte significativa de nossos processos. O suporte e a colaboração contínua dessas instituições são fundamentais para o nosso progresso.

## NuGets

   - Biblioteca AWSSDK - https://github.com/aws/aws-sdk-net/
   - Biblioteca DnsClient - https://dnsclient.michaco.net/
   - Biblioteca Krypton.Toolkit - https://github.com/Krypton-Suite/Standard-Toolkit
   - Biblioteca Krypton - https://github.com/ComponentFactory/Krypton
   - Biblioteca MongoDB.Bson - https://www.mongodb.com/docs/drivers/csharp/current/
   - Biblioteca MongoDB.Driver - https://www.mongodb.com/docs/drivers/csharp/current/
   - Biblioteca MongoDB.Driver.Core - https://www.mongodb.com/docs/drivers/csharp/current/
   - Biblioteca MongoDB.Libmongocrypt - https://www.mongodb.com/docs/drivers/csharp/current/

---

# Apoie-nos 💖

Apoie SpaceCalc! dependemos do apoio e da generosidade de pessoas como você para continuar inovando e proporcionando soluções de qualidade. Se você acredita na nossa missão e gostaria de contribuir para o avanço de nossos projetos, considere seguir nosso repositório e compartilhar para próximos. Sua participação é fundamental para o crescimento e sucesso da nossa comunidade. Juntos, podemos levar SpaceCalc a novos patamares! 

Obrigado pelo seu apoio e deixe sua ⭐!
