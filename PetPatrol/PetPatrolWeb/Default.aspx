<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="PetPatrolWeb._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

     <div class="container mt-4 text-center"> <!-- Añadido text-center para centrar el contenido -->
        <h1 class="display-4">PetPatrol</h1>
        <p class="lead">Tu comunidad para encontrar mascotas perdidas y reunirlas con sus familias.</p>

        <!-- Slider de Publicaciones de Mascotas Perdidas -->
        <div id="carouselMascotasPerdidas" class="carousel slide" data-ride="carousel">
            <!-- Aquí irían los indicadores del carrusel (opcional) -->
            <div class="carousel-inner">
                <!-- Aquí van los elementos del carrusel (las imágenes) -->
                <!-- Ejemplo de un elemento del carrusel -->
                <div class="carousel-item active">
                    <img class="d-block w-100" src="ruta_a_imagen_mascota1.jpg" alt="Mascota Perdida 1">
                    <div class="carousel-caption d-none d-md-block">
                        <h5>Nombre de la Mascota 1</h5>
                        <p>Breve descripción o ubicación donde se perdió.</p>
                    </div>
                </div>
                <!-- Repite el div anterior para más elementos en el carrusel -->
            </div>
            <!-- Controles del carrusel -->
            <a class="carousel-control-prev" href="#carouselMascotasPerdidas" role="button" data-slide="prev">
                <span class="carousel-control-prev-icon" aria-hidden="true"></span>
                <span class="sr-only">Anterior</span>
            </a>
            <a class="carousel-control-next" href="#carouselMascotasPerdidas" role="button" data-slide="next">
                <span class="carousel-control-next-icon" aria-hidden="true"></span>
                <span class="sr-only">Siguiente</span>
            </a>
        </div>

        <!-- Sección de Acciones Principales -->
        <div class="mt-4">
            <p>¿Has perdido a tu mascota o has encontrado una? Estás en el lugar correcto para buscar ayuda.</p>
            <p>
                <a class="btn btn-primary btn-lg" href="Publicar.aspx" role="button">Publicar Mascota</a>
                <a class="btn btn-secondary btn-lg" href="Buscar.aspx" role="button">Buscar Mascotas</a>
            </p>
        </div>
        
        <!-- Sección de características -->
        <div class="row">
            <div class="col-md-4">
                <h2>Publicaciones Recientes</h2>
                <p>Descubre las últimas mascotas reportadas en nuestra comunidad. Tu ayuda puede hacer la diferencia.</p>
                <p><a class="btn btn-secondary" href="PublicacionesRecientes.aspx" role="button">Ver publicaciones &raquo;</a></p>
            </div>
            <div class="col-md-4">
                <h2>Consejos y Recursos</h2>
                <p>Encuentra consejos útiles sobre cómo mantener a tu mascota segura y qué hacer si se pierde.</p>
                <p><a class="btn btn-secondary" href="Consejos.aspx" role="button">Leer más &raquo;</a></p>
            </div>
            <div class="col-md-4">
                <h2>Únete a Nuestra Comunidad</h2>
                <p>Regístrate para participar activamente en nuestra red de apoyo. Juntos podemos hacer una diferencia.</p>
                <p><a class="btn btn-secondary" href="Registro.aspx" role="button">Registrarse &raquo;</a></p>
            </div>
        </div>
    </div>

</asp:Content>
