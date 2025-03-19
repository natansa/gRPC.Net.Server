# gRPC.Net.Server 🚀

Este repositório contém um **servidor gRPC** desenvolvido em **.NET 9**, que fornece um serviço de **Bidirectional Streaming** para troca de dados do objeto `Person`.

## 📖 Sobre

O servidor implementa o serviço **PersonService**, permitindo comunicação via gRPC entre **clientes e o servidor**. Ele recebe **dados de pessoas**, processa e devolve os dados modificados.

Os clientes podem enviar múltiplos objetos `Person` de forma **assíncrona** e receber **respostas em tempo real**.

### 🔹 **Modelo de Dados (`Person`)**
| Propriedade    | Tipo     | Descrição                          |
|---------------|---------|----------------------------------|
| `Name`        | string  | Nome da pessoa                   |
| `DateOfBirth` | string  | Data de nascimento (ISO format) |
| `Age`         | int     | Idade da pessoa                  |
| `Active`      | bool    | Status da pessoa                 |

---

## 📌 Requisitos

Antes de rodar o servidor, certifique-se de ter:

✅ **.NET 9** instalado  
✅ **Porta 7192 liberada para conexões gRPC**  
✅ **Arquitetura baseada em HTTP/2 habilitada**  

---

## 📥 Instalação

1️⃣ **Clone o repositório**
```sh
git clone https://github.com/seu-usuario/gRPC.Net.Server.git
cd gRPC.Net.Server
