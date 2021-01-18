/*
MANTENHA A LÍNGUA - DO SEU SQL SERVER - EM PORTUGUÊS DO BRASIL


1. Comando para verificar a linguagem atual do SQL Server ↓
	Select @@langid, @@language

2.	Comando para verificar as linguagens disponíveis no SQL Server ↓
	EXEC sp_helplanguage

3. Comando para alterar a linguagem do usuário 'sa' para Português do Brasil ↓
	Exec sp_defaultlanguage 'sa', 'Português (Brasil)'
	Reconfigure

4. A senha criptografada é equivalente a 123123123

*/
USE Hackathon_Db;
GO

--DML

INSERT INTO TipoUsuario (NomeTipoUsuario)
VALUES		('Administrador'),
			('Candidato'),
			('Empresa'),
			('Banido');
GO

INSERT INTO StatusInscricao (NomeStatusInscricao)
VALUES		('Aprovado'),
			('Em Andamento'),
			('Recusado');
GO

INSERT INTO Area (NomeArea)
VALUES		('Desenvolvimento'),
			('Redes'),
			('Multimídia'),
			('Engenharia de softwere'),
			('Analista de dados'),
			('Especialista financeiro'),
			('Assistente de pedreiro'),
			('Instrumentos musicais'),
			('Educação');
GO

INSERT INTO TipoRegimePresencial(NomeTipoRegimePresencial)
VALUES		('Presencial'),
			('Semipresencial'),
			('Remoto');
GO

--Só consegui pensar em tecnologias na area de softwer '-'

INSERT INTO Tecnologia (NomeTecnologia)
VALUES		('Não definido'),
			('Vue.Js'),
			('Firebase'),
			('SQL Server'),
			('Entity framework'),
			('Windows Form'),
			('AWS Cloud'),
			('PHP'),
			('Java'),
			('Python'),
			('HTML'),
			('CSS'),
			('WordPress'),
			('Angular'),
			('Git'),
			('GitHub'),
			('Devops'),
			('Redux'),
			('CSharp')
GO

INSERT INTO Usuario (Email, Senha, IdTipoUsuario,PerguntaSeguranca,RespostaSeguranca)
VALUES('possarle@gmail.com', '932f3c1b56257ce8539ac269d7aab42550dacf8818d075f0bdf1990562aae3ef', 1,'Qual o nome do administrador','Roberto Possarle')
GO

INSERT INTO Empresa(NomeReponsavel,CNPJ,EmailContato,NomeFantasia,RazaoSocial,Telefone,NumFuncionario,NumCNAE,CEP,Logradouro,Complemento,Localidade,UF,IdUsuario)
VALUES('CodeAlliance','12312345672124','CodeAlliance@gmail.com','Code Enterprise','Code Enterprise','12341111112','50','1234567','12345679','Rua 2','Perto da loja de piano','São Paulo','SP',3)
GO

INSERT INTO Candidato(NomeCompleto,RG,CPF,Telefone,LinkLinkedinCandidato,IdCurso,IdUsuario)
VALUES('André Akira','123352345','12487664567','52341102345','André/Linkedin.com',2,3),
	('Douglas Mantovani','122652345','18487664567','52301112345','Douglas/Linkedin.com',6,4)
GO

INSERT INTO Vaga(TituloVaga,DescricaoVaga,DescricaoEmpresa,DescricaoBeneficio,DataPublicacao,DataExpiracao,Experiencia,TipoContrato,Salario,Localidade,Estado,CEP,Logradouro,IdTipoRegimePresencial,Complemento,IdEmpresa,IdArea)
VALUES('Desenvolvedor Full Stack','Será o responsavel por resolver os nossos problemas','Somos um grupo em uma curva grande de crescimento no mercado','você será o nosso funcionário','30-11-2020','30-12-2020','Pleno','CLT',2000,'São Paulo','SP','14875458','Rua Barão de Limeira',1,'Perto da folha',1,1),
('Técnico de Redes','Será o responsavel por resolver os nossos problemas','Somos um grupo em uma curva grande de crescimento no mercado','você será o nosso funcionário','30-11-2020','30-12-2020','Pleno','PJ',5000,'São Paulo','SP','14875458','Rua Barão de Limeira',2,'Perto da folha',1,1),
('Designer','Será o responsavel por estilizar nosso sistema','Somos um grupo em uma curva grande de crescimento no mercado','você será o nosso funcionário','30-11-2020','30-12-2020','Júnior','CLT',3000,'São Paulo','SP','14875458','Rua Barão de Limeira',3,'Perto da folha',1,1)
GO

INSERT INTO VagaTecnologia(IdVaga,IdTecnologia)
VALUES(1,6),
(2,11),
(3,2)
GO

INSERT INTO Inscricao(DataInscricao,IdCandidato,IdVaga,IdStatusInscricao)
VALUES('30-11-2020',1,1,2),
('30-11-2020',2,1,2)
GO
