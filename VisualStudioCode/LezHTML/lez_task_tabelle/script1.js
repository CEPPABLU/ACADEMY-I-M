let contenuto = "";
let i = 0;

function verifica(){
  let nome = document.getElementById('input-nome').value;
  let cognome = document.getElementById('input-cognome').value;
  let tel = document.getElementById('input-tel').value; 

  contenuto +=`
  <tr>
  <td>${i+1}</td>
  <td>${nome}</td>
  <td>${cognome}</td>
  <td>${tel}</td>
  </tr>
  `
  
  i++;
  document.getElementById("corpo-tabella").innerHTML = contenuto;
}