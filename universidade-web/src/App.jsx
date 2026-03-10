import { useState } from "react"
import axios from "axios"

function App(){

const [nome,setNome] = useState("")
const [cpf,setCpf] = useState("")
const [email,setEmail] = useState("")

async function cadastrar(){

await axios.post("http://localhost:5179/api/pessoafisica",{
nome:nome,
cpf:cpf,
email:email
})

alert("Cadastro realizado")

setNome("")
setCpf("")
setEmail("")
}

return(

<div style={{padding:"40px"}}>
<h1>Sistema Universidade</h1>

<input
placeholder="Nome"
value={nome}
onChange={(e)=>setNome(e.target.value)}
/>

<br/><br/>

<input
placeholder="CPF"
value={cpf}
onChange={(e)=>setCpf(e.target.value)}
/>

<br/><br/>

<input
placeholder="Email"
value={email}
onChange={(e)=>setEmail(e.target.value)}
/>

<br/><br/>

<button onClick={cadastrar}>
Cadastrar
</button>

</div>

)

}

export default App