    function TablaJuegos() {
        fetch('http://localhost:5122/JuegoTarde')
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
document.addEventListener("DOMContentLoaded", function () {
    TablaJuegos();

    var inputFirst = document.getElementById('inputFirst');
    inputFirst.addEventListener('keydown', function (event) {
        if (event.keyCode === 13) {
            document.getElementById('button').click();
        }
    });
});