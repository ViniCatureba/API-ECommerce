# Passo a passo API


Primeiro criamos a Interface, sempre com o prefixo  I e no sufixo Repository
Na interface indicamos os metodos que terão em nossa API

voce declada a interface como:

public interface IInterfaceName{

aqui vocÊ cria as metodos, ex crud:

List<"ModelName"> ListarTodos();
"ModelName" BuscarPorId(int id);
void Cadastrar ("ModelName" modelName);
void Atualizar(int id, "ModelName" modelNome

}

--------------------------------------------------------------------------------------

# Crie seu Repository

Com sufixo Repository

Declara a herança do Iterface para o Repository

declaraa os metodos (implementa a interface

cria a variavel _context

e injeta o context 

se usar o control + . na interface, vai te dar a opção de inserir automaticamente os metodos da interface

depois começa a implementar os metodos usando o context para usar o bando de dados.

Não esquecer de quando for uma operação que altera o banco, de usar o comando _context.SaveChanges();

-------------------------------------------------------------------------------------------------------

# Configurar a injeção de dependenciar para criar a instancias para usar no controller

builder.Service.


-------------------------------------------------------------------------------------------------------

# Criar controllers com sufixo Controllers

herda a interface

E injetar o Repository

criar as rotas dos metodos, idnicar a operação, ex get, post...
cri as metodos crud
e retornar o codigo.


-----------------------------------------------------------------------------------------------------
# Configurar o Swagger

