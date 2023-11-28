
// Función para llenar la tabla de usuarios
//document.addEventListener("DOMContentLoaded", 
    function TablaJuegos() {
        fetch('http://localhost:5122/Eleccion') // Reemplaza con la URL de tu API
            .then(response => response.json())
            .then(data => {
                var tablaJuegos = document.getElementById('listado');
                data.forEach(JuegoVotos => {
                    var fila = document.createElement("tr");
                    fila.innerHTML = `
                    <td>${JuegoVotos.juegos}</td> 
                    <td>${JuegoVotos.cantVotos}</td>`;
                    tablaJuegos.appendChild(fila);
                });
            })
            .catch(error => {
                console.error('Error al obtener datos:', error);
            });
    }


// Llama a la función para llenar la tabla cuando el DOM esté listo
document.addEventListener("DOMContentLoaded", TablaJuegos);