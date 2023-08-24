$('.close-alert').click(function () {
    $('.alert').hide('hide');
});
function ValidateSetor() {
    var Nome = document.getElementById("nome").value;
    var Nome_Ingles = document.getElementById("nome-ingles").value;

    var isValid = true;

    if (Nome == "" || Nome.trim() === "") {
        document.getElementById("nomeAlert").innerHTML = 'O nome é obrigatório';
        isValid = false;
    }
    if (Nome_Ingles == "" || Sigla.trim() === "") {
        document.getElementById("nomeInglesAlert").innerHTML = 'O nome em ingles é obrigatório';
        isValid = false;
    }
    return isValid;
}

function ValidateFuncao() {
    var Nome = document.getElementById("nome").value;
    var Nome_Ingles = document.getElementById("nome-ingles").value;

    var isValid = true;

    if (Nome == "" || Nome.trim() === "") {
        document.getElementById("nomeAlert").innerHTML = 'O nome é obrigatório';
        isValid = false;
    }
    if (Nome_Ingles == "" || Sigla.trim() === "") {
        document.getElementById("nomeInglesAlert").innerHTML = 'O nome em ingles é obrigatório';
        isValid = false;
    }
    return isValid;
}

function ValidateEstado() {
    var Nome = document.getElementById("nome").value;
    var Sigla = document.getElementById("siglas").value;

    var isValid = true;

    if (Nome == "" || Nome.trim() === "") {
        document.getElementById("nomeAlert").innerHTML = 'O nome é obrigatório';
        isValid = false;
    }
    if (Sigla == "" || Sigla.trim() === "") {
        document.getElementById("siglasAlert").innerHTML = 'A sigla é obrigatório';
        isValid = false;
    }
    return isValid;
}

function ValidateCidade() {
    var Nome = document.getElementById("nome").value;
    var Estado = document.getElementById("estado").value;

    var isValid = true;

    if (Nome == "" || Nome.trim() === "") {
        document.getElementById("nomeAlert").innerHTML = 'O nome é obrigatório';
        isValid = false;
    }
    if (Estado == "" || Estado.trim() === "") {
        document.getElementById("estadoAlert").innerHTML = 'O estado é obrigatório';
        isValid = false;
    }
    return isValid;

}

function ValidateAtividadeEconomica() {
    var Codigo = document.getElementById("codigo").value;
    var Nome = document.getElementById("nome").value;

    var isValid = true;

    if (Codigo == "" || Codigo.trim() === "") {
        document.getElementById("codigoAlert").innerHTML = 'O codigo é obrigatório';
        isValid = false;
    }
    if (Nome == "" || Nome.trim() === "") {
        document.getElementById("nomeAlert").innerHTML = 'O nome é obrigatório';
        isValid = false;
    }
    return isValid;
}

function ValidateEmpresa() {
    var RazaoSocial = document.getElementById("razao-social").value;
    var NumeroEmpregados = document.getElementById("numero-empregados").value;
    var CNAE = document.getElementById("cnae").value;
    var Data_Cadastro = document.getElementById("data-cadastro").value;
    var Observacao = document.getElementById("observacao").value;
    var CNPJ = document.getElementById("cnpj").value;
    var Endereco = document.getElementById("endereco").value;
    var Complemento = document.getElementById("complemento").value;
    var Bairro = document.getElementById("bairro").value;
    var CEP = document.getElementById("cep").value;
    var Cidade = document.getElementById("cidade").value;
    var Atividade_Economica = document.getElementById("atividade-economica").value;

    var isValid = true;

    if (RazaoSocial == "" || RazaoSocial.trim() === "") {
        document.getElementById("razaoSocialAlert").innerHTML = 'A razão social é obrigatória';
        isValid = false;
    }
    if (NumeroEmpregados == "" || NumeroEmpregados.trim() === "") {
        document.getElementById("numeroEmpregadosAlert").innerHTML = 'O numero de empregados é obrigatório';
        isValid = false;
    }
    if (CNAE == "" || CNAE.trim() === "") {
        document.getElementById("cnaeAlert").innerHTML = 'O CNAE é obrigatório';
        isValid = false;
    }
    if (Data_Cadastro == "" || Data_Cadastro.trim() === "") {
        document.getElementById("dataCadastroAlert").innerHTML = 'A data de cadastro é obrigatória';
        isValid = false;
    }
    if (Observacao == "" || Observacao.trim() === "") {
        document.getElementById("observacaoAlert").innerHTML = 'A observação é obrigatório';
        isValid = false;
    }
    if (CNPJ == "" || CNPJ.trim() === "") {
        document.getElementById("cnpjAlert").innerHTML = 'O CNPJ é obrigatório';
        isValid = false;
    }
    if (Endereco == "" || Endereco.trim() === "") {
        document.getElementById("enderecoAlert").innerHTML = 'O endereço é obrigatório';
        isValid = false;
    }
    if (Complemento == "" || Complemento.trim() === "") {
        document.getElementById("complementoAlert").innerHTML = 'O complemento é obrigatório';
        isValid = false;
    }
    if (Bairro == "" || Bairro.trim() === "") {
        document.getElementById("bairroAlert").innerHTML = 'O bairro é obrigatório';
        isValid = false;
    }
    if (CEP == "" || CEP.trim() === "") {
        document.getElementById("cepAlert").innerHTML = 'O CEP é obrigatório';
        isValid = false;
    }
    if (Cidade == "" || Cidade.trim() === "") {
        document.getElementById("cidadeAlert").innerHTML = 'A cidade é obrigatória';
        isValid = false;
    }
    if (Atividade_Economica == "" || Atividade_Economica.trim() === "") {
        document.getElementById("atividadeEconomicaAlert").innerHTML = 'A atividade economica é obrigatória';
        isValid = false;
    }
    return isValid;
}


function Validate() {
    var CPF = document.getElementById("cpf").value;
    var Nome = document.getElementById("nome").value;
    var NomeMae = document.getElementById("nome-mae").value;
    var Data_Nascimento = document.getElementById("data-nascimento").value;
    var Email = document.getElementById("email").value;
    var Celular = document.getElementById("celular").value;

    var isValid = true;

    if (CPF == null || CPF === "") {
        document.getElementById("cpfAlert").innerHTML = 'O cpf é obrigatório';
        isValid = false;
    }

    if (Nome == "" || Nome.trim() === "") {
        document.getElementById("nomeAlert").innerHTML = 'O nome é obrigatório';
        isValid = false;
    }

    if (NomeMae == "" || NomeMae.trim() === "") {
        document.getElementById("nomeMaeAlert").innerHTML = 'O nome da mãe é obrigatório';
        isValid = false;
    }

    if (Data_Nascimento == "" || Data_Nascimento.trim() === "") {
        document.getElementById("dataNascAlert").innerHTML = 'A data de nascimento é obrigatório';
        isValid = false;
    }
    if (Email == "" || Email.trim() === "") {
        document.getElementById("emailAlert").innerHTML = 'O email é obrigatório';
        isValid = false;
    }
    if (Celular == "" || Celular.trim() === "") {
        document.getElementById("celularAlert").innerHTML = 'O celular é obrigatório';
        isValid = false;
    }
    return isValid;
}

function ValidateEdition() {
    var CPF = document.getElementById("cpf").value;
    var Nome = document.getElementById("nome").value;
    var Data_Nascimento = document.getElementById("data-nascimento").value;

    var isValid = true;

    if (CPF == null || CPF === "") {
        document.getElementById("cpfAlertEdicao").innerHTML = 'O cpf é obrigatório';
        isValid = false;
    }

    if (Nome == "" || Nome.trim() === "") {
        document.getElementById("nomeAlertEdicao").innerHTML = 'O nome é obrigatório';
        isValid = false;
    }

    if (Data_Nascimento == "" || Data_Nascimento.trim() === "") {
        document.getElementById("dataNascAlertEdicao").innerHTML = 'A data de nascimento é obrigatório';
        isValid = false;
    }
    return isValid;
}
function ValidateEditionMultiEmpresas() {
    var CPF = document.getElementById("cpfMultiEmpresas").value;
    var Nome = document.getElementById("nomeMultiEmpresas").value;
    var Data_Nascimento = document.getElementById("data-nascimentoMultiEmpresas").value;

    var isValid = true;

    if (CPF == null || CPF === "") {
        document.getElementById("cpfAlertEdicaoMultiEmpresas").innerHTML = 'O cpf é obrigatório';
        isValid = false;
    }

    if (Nome == "" || Nome.trim() === "") {
        document.getElementById("nomeAlertEdicaoMultiEmpresas").innerHTML = 'O nome é obrigatório';
        isValid = false;
    }

    if (Data_Nascimento == "" || Data_Nascimento.trim() === "") {
        document.getElementById("dataNascAlertEdicaoMultiEmpresas").innerHTML = 'A data de nascimento é obrigatório';
        isValid = false;
    }
    return isValid;
}
function ValidateExame() {
    var Nome_Exame = document.getElementById("nome-exame").value;
    var Nome_Exame_Ingles = document.getElementById("nome-exame-ingles").value;

    var isValid = true;

    if (Nome_Exame == null || Nome_Exame.trim() === "") {
        document.getElementById("nomeExameAlert").innerHTML = 'O nome do exame é obrigatório';
        isValid = false;
    }

    if (Nome_Exame_Ingles == "" || Nome_Exame_Ingles.trim() === "") {
        document.getElementById("nomeExameInglesAlert").innerHTML = 'O nome é obrigatório';
        isValid = false;
    }
    return isValid;
}
function ValidateEditionExame() {
    var Nome_Exame = document.getElementById("nome-exame-edicao").value;
    var Nome_Exame_Ingles = document.getElementById("nome-exame-ingles-edicao").value;

    var isValid = true;

    if (Nome_Exame == null || Nome_Exame.trim() === "") {
        document.getElementById("nomeExameEdicaoAlert").innerHTML = 'O nome do exame é obrigatório';
        isValid = false;
    }

    if (Nome_Exame_Ingles == "" || Nome_Exame_Ingles.trim() === "") {
        document.getElementById("nomeExameInglesEdicaoAlert").innerHTML = 'The name is required';
        isValid = false;
    }
    return isValid;
}

function validarNumero(input) {

    input.value = input.value.replace(/\D/g, '');
}
