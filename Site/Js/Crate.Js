function CreateDoador(){
    const Nome = document.getElementById(Name).value;
    const Estado = document.getElementById(state).value;
    const Cep = document.getElementById(Zip).value;
    const Email = document.getElementById(Email).value;
    const Telefone = document.getElementById(telephone).value;

    const data ={
        Nome:Nome,
        Estado:Estado,
        Cep:Cep,
        Email:Email,
        Telefone:Telefone,
    }
    fetch('https://localhost:7279/api/Doador/CadastrarDoador',{
 
    method: 'POST',
    headers: {
        'Content-Type': 'application/json'
    },
    body: JSON.stringify(data)
    }).then(response => {
        if(!response.ok){
            alert("Erro ao criar pessoa");
        }
        alert("pessoa criada com sucesso!");
        window.location.href = '../index.html';
    })
    
}