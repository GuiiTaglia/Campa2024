
// Función para llenar la tabla de usuarios
//document.addEventListener("DOMContentLoaded", 
    function TablaJuegos() {
        fetch('http://localhost:5237/JuegoNoche') // Reemplaza con la URL de tu API
            .then(response => response.json())
            .then(data => {
                var tablaJuegos = document.getElementById('listado');
                data.forEach(Juego => {
                    var fila = document.createElement("tr");
                    fila.innerHTML = `
                    <td>${Juego.nroJuego}</td> 
                    <td>${Juego.nombre}</td>
                    <td>${Juego.descripcion}</td>`;
                    tablaJuegos.appendChild(fila);
                });
            })
            .catch(error => {
                console.error('Error al obtener datos:', error);
            });
    }


// Llama a la función para llenar la tabla cuando el DOM esté listo
document.addEventListener("DOMContentLoaded", TablaJuegos);