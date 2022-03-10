$(document).ready(function () {

    $("#Valor").maskMoney({
        prefix: "R$:",
        decimal: ",",
        thousands: "."
    });

    function limpa_formulário_cep() {
        // Limpa valores do formulário de cep.
        $("#BillingAddress1").val("");
        $("#Neighborhood").val("");
        $("#City").val("");
        $("#State").val("");
    }

    //Quando o campo cep perde o foco.
    $("#ZipCode").blur(function () {


        //Nova variável "cep" somente com dígitos.
        var cep = $(this).val().replace(/\D/g, '');

        //Verifica se campo cep possui valor informado.
        if (cep != "") {

            //Expressão regular para validar o CEP.
            var validacep = /^[0-9]{8}$/;

            //Valida o formato do CEP.
            if (validacep.test(cep)) {

                //Preenche os campos com "..." enquanto consulta webservice.
                $("#BillingAddress1").val("...");
                $("#Neighborhood").val("...");
                $("#City").val("...");
                $("#State").val("...");

                //Consulta o webservice viacep.com.br/
                $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?", function (dados) {

                    if (!("erro" in dados)) {
                        //Atualiza os campos com os valores da consulta.
                        $("#BillingAddress1").val(dados.logradouro);
                        $("#Neighborhood").val(dados.bairro);
                        $("#City").val(dados.localidade);
                        $("#State").val(dados.uf);
                    } //end if.
                    else {
                        //CEP pesquisado não foi encontrado.
                        limpa_formulário_cep();
                        alert("CEP não encontrado.");
                    }
                });
            } //end if.
            else {
                //cep é inválido.
                limpa_formulário_cep();
                alert("Formato de CEP inválido.");
            }
        } //end if.
        else {
            //cep sem valor, limpa formulário.
            limpa_formulário_cep();
        }
    });
});