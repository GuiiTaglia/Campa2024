document.addEventListener("DOMContentLoaded", function (event) {
    console.info("IngresarJuego")
});

document.getElementById('registroForm').addEventListener('submit', function (event) {
    event.preventDefault(); // Prevenir el envío del formulario normal

    //const grupo = document.getElementById('NroEquipoVotante').value;

    /*function ingresarNumero(numero) {
        return numero;
    }

    function enviarFormulario() {
        var dato = document.getElementById("dato").value;
        return dato;
    }*/
    
    const juego = document.getElementById('NroJuegoElegido').value;
    const equipo = document.getElementById('NroEquipoVotante').value;

    const datos = {
        'NroJuegoElegido': juego,
        'NroEquipoVotante': equipo
    }

    // Enviar los datos a una API REST (sustituye la URL por la de tu API)
    fetch('http://localhost:5122/Eleccion', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(datos)
    })
        .then(response => {
            if (!response.ok) {
                throw new Error('Bad Request'); // Lanzar un error personalizado si la respuesta no es exitosa (código de estado diferente de 2xx)
            }
            return response.json(); // Convertir la respuesta a JSON si es exitosa
        })
        .then(data => {
            // Manejar la respuesta de la API aquí
            console.log('Respuesta de la API:', data);
            alert('Registro exitoso');
        })
        .catch(error => {
            // Manejar errores aquí
            console.error('Error al enviar los datos:', error);
            alert('Hubo un error al procesar el registro');
        });
});


