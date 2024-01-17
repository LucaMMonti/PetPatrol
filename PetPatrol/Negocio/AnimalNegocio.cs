
using Dominio;
using System;
using System.Collections.Generic;

namespace Negocio
    {
        public class AnimalNegocio
        {
            public List<Animal> Listar()
            {
                List<Animal> lista = new List<Animal>();
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearConsulta("SELECT ID, Nombre, Especie, Raza, Sexo, Color, Edad, Tamanio, Descripcion, Perdido, FechaPerdida, FechaEncontrada, FechaAdopcion, Castrado FROM Animales");
                    datos.ejecutarLectura();

                    while (datos.Lector.Read())
                    {
                        Animal aux = new Animal
                        {
                            ID = (int)datos.Lector["ID"],
                            Nombre = (string)datos.Lector["Nombre"],
                            Especie = (string)datos.Lector["Especie"],
                            Raza = (string)datos.Lector["Raza"],
                            Sexo = (string)datos.Lector["Sexo"],
                            Color = (string)datos.Lector["Color"],
                            Edad = (int)datos.Lector["Edad"],
                            Tamanio = (string)datos.Lector["Tamanio"],
                            Descripcion = (string)datos.Lector["Descripcion"],
                            Perdido = (bool)datos.Lector["Perdido"],
                            FechaPerdida = (string)datos.Lector["FechaPerdida"],
                            FechaEncontrada = (string)datos.Lector["FechaEncontrada"],
                            FechaAdopcion = (string)datos.Lector["FechaAdopcion"],
                            Castrado = (bool)datos.Lector["Castrado"]                          
                        };
                        lista.Add(aux);
                    }
                    return lista;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }

            public void Agregar(Animal animal)
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    string valores = "values(@Nombre, @Especie, @Raza, @Sexo, @Color, @Edad, @Tamanio, @Descripcion, @Perdido, @FechaPerdida, @FechaEncontrada, @FechaAdopcion, @Castrado)";
                    datos.setearConsulta("INSERT INTO Animales (Nombre, Especie, Raza, Sexo, Color, Edad, Tamanio, Descripcion, Perdido, FechaPerdida, FechaEncontrada, FechaAdopcion, Castrado) " + valores);

                    datos.agregarParametro("@Nombre", animal.Nombre);
                    datos.agregarParametro("@Especie", animal.Especie);
                    datos.agregarParametro("@Raza", animal.Raza);
                    datos.agregarParametro("@Sexo", animal.Sexo);
                    datos.agregarParametro("@Color", animal.Color);
                    datos.agregarParametro("@Edad", animal.Edad);
                    datos.agregarParametro("@Tamanio", animal.Tamanio);
                    datos.agregarParametro("@Descripcion", animal.Descripcion);
                    datos.agregarParametro("@Perdido", animal.Perdido);
                    datos.agregarParametro("@FechaPerdida", animal.FechaPerdida);
                    datos.agregarParametro("@FechaEncontrada", animal.FechaEncontrada);
                    datos.agregarParametro("@FechaAdopcion", animal.FechaAdopcion);
                    datos.agregarParametro("@Castrado", animal.Castrado);
              
                    datos.ejecutarAccion();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    datos.cerrarConexion();
                }
            }

            public void Modificar(Animal animal)
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearConsulta("UPDATE Prenda SET Nombre = @Nombre, Especie = @Especie, Raza = @Raza, Sexo = @Sexo, Color = @Color, Edad = @Edad," +
                                        " Tamanio = @Tamanio, Descripcion = @Descripcion, Perdido = @Perdido, FechaPerdida = @FechaPerdida, FechaEncontrada = @FechaEncontrada, FechaAdopcion = @FechaAdopcion, Castrado = @Castrado");

                    datos.agregarParametro("@Nombre", animal.Nombre);
                    datos.agregarParametro("Especia", animal.Especie);
                    datos.agregarParametro("Raza", animal.Raza);
                    datos.agregarParametro("Sexo", animal.Sexo);
                    datos.agregarParametro("Color", animal.Color);
                    datos.agregarParametro("Edad", animal.Edad);
                    datos.agregarParametro("Tamanio", animal.Tamanio);
                    datos.agregarParametro("Descripcion", animal.Descripcion);
                    datos.agregarParametro("Perdido", animal.Perdido);
                    datos.agregarParametro("FechaPerdida", animal.FechaPerdida);
                    datos.agregarParametro("FechaEncontrada", animal.FechaEncontrada);
                    datos.agregarParametro("FechaAdopcion", animal.FechaAdopcion);
                    datos.agregarParametro("Castrado", animal.Castrado);

                    datos.ejecutarLectura();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    datos.cerrarConexion();
                }              
            }

            public void Eliminar(int ID)
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearConsulta("DELETE FROM Animal WHERE ID = @id");
                    datos.agregarParametro("@id", ID);
                    datos.ejecutarAccion();
                }
                catch (Exception ex)
                {
                    throw ex;
                }           
            }
        }
}

