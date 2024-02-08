document.addEventListener('DOMContentLoaded', function(){
 
    const DoadorList= document.getElementById('Doador-lista');
 
    function renderTable(data){/*função para aparecer na tela */
    DoadorList.innerHTML='';
 
        data.forEach(Doador =>{
            const row = document.createElement('tr');
            row.innerHTML= `
<td>${Doador.DoadorId}</td>
<td>${Doador.Nome}</td>
<td>${Doador.Estado}</td>
<td>${Doador.Cep}</td>
<td>${Doador.Email}</td>
<td>${Doador.Telefone}</td>
<td>
<button>Editar</button>
<button>Excluir</button>
</td>
            `;
            DoadorList.appendChild(row);
        })
    }
 
    function feachDoador(){
        fetch("https://localhost:7279/api/Doador/CadastrarDoador")
        .then(response => response.json())
        .then(data => renderTable(data))
        .catch(error => console.error('Erro ao buscar dados da API'))
    }
    feachDoador();
 
})
fetch('https://localhost:7279/api/Doador/CadastrarDoador',{
 
method: 'post',
headers: {
    'content-type': 'application/json'
},
}).then(response => {
    if(!response.ok){
        alert("Erro ao criar pessoa");
    }
    alert("pessoa criada com sucesso!");
    window.location.href = 'index.html';
})

function CreateDoador(){
    window.location.href = 'pages/Create.html';
}