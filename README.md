Sistema Saúde

O Sistema Saúde é uma aplicação desenvolvida em C# e Windows Forms, utilizando Orientação a Objetos e Lambda. A aplicação permite a criação de registros nas tabelas PACIENTE, DIAGNÓSTICO e ATENDIMENTO, com foco na organização e persistência de dados. A interação com o banco de dados é feita utilizando Entity Framework (ORM).

Funcionalidades principais:

-Cadastro de Pacientes: Registro de informações detalhadas dos pacientes, incluindo matrícula, diagnóstico e dados pessoais.
-Atendimento: Registro completo de atendimentos realizados, com informações específicas sobre o processo.
-Diagnóstico: Seleção e registro de diagnósticos simples para cada paciente.
-Persistência de Dados: Armazenamento de todos os dados no banco de dados usando Entity Framework.

-Commit 07/02/2025:

-Criado tabela usuário e tela para login e criação de novo usuário.
-Adicionado API do IBGE para buscar todas cidades do RS para adicionar no ComboForm "Locais".
Link da API: https://servicodados.ibge.gov.br/api/v1/localidades/estados/43/municipios
-Adicionado pasta "Controller" para ficar no formato MVC e funções para buscar: Convenios, Escolaridade, Locais, Planos, Tipos de atendimento.
-Adicionado informações das tabelas criadas no app.quickdatabasediagrams.com para ter uma demonstração visual do banco de dados
