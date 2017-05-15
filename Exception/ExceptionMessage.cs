using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class ExceptionMessage
    {
        //Users Exceptions
        public static string userNameNull = "El nombre de usuario no puede ser nulo o vacio";
        public static string userSurnameNull = "El apellido de usuario no puede ser nulo o vacio";
        public static string userBirthdateInvalid = "La fecha de nacimiento no puede ser mayor a la fecha acutal";
        public static string userPasswordInvalid = "La contraseña no puede ser nula o vacia y debe tener almenos 6 caracteres, inlcuyendo numeros y letras";
        public static string userMailInvail = "El mail no puede ser nulo o vacio, y debe se del estilo: nombreMail@gmail.com";


        //Team Exceptions
        public static string teamNameNullOrEmpty = "El nombre del equipo no puede ser nulo o vacio";
        public static string teamOwnerNull = "El equipo debe poseer un usuario creador";
        public static string teamDescriptionInvalid = "La descripcion no puede ser nula o vacia y debe ser menor a 51 caracteres";
        public static string teamUserListEmpty = "El equipo debe tener al menos 1 usuario";
        public static string teamMaxUsers = "El equipo debe tener un maximo de usuario mayor a 0";
        public static string teamUsersListFull = "No se puden ingresar mas usuario, cantidad maxima alcanzada";
        public static string teamFutureDate = "La fecha de creacio no puede mayor a la fecha actual";
        public static string teamModifyMaxUsers = "La cantidad maxima de usuarios no puede ser menor a la cantidad actual";


        //Blackboard Exceptions
        public static string blackboardElementCollecionNull = "La lista de elementos del pizarron no puede ser nula";
        public static string blackboardTeamOwnerNull = "El pizarron debe tener un equipo al que pertenecer";
        public static string blackboardHeightOrWidthNegative = "El ancho y largo del pizarron no pueden ser negativos";
        public static string blackboardHeightOrWidthZero = "El ancho y largo del pizarron no pueden ser cero";
        public static string blackboardDescriptionSize = "El largo de la descripcion no puede superar los 50 caracteres";
        public static string blackboardDescriptionAndNameNull = "El nombre y descripcion del pizarron no pueden ser nulos o vacios";
        public static string blackboardNameSize = "El nombre del pizarron no puede superar los 20 caracteres";
        public static string blackboardUserCreatorNull = "El pizarron debe tener un usuario creador";

        //Element Exceptions
        public static string elementBlackboardNull = "El elemento debe pertenecer a un pizarron";
        public static string elementUserDoesNotBelongToTheTeam = "El usuario que crea el elemento debe pertenecer al equipo de dicho elemento";
        public static string elementUserNull = "El elemento debe ser creado por un usuario";
        public static string elementNegativeNumber = "El largo, ancho y punto de origen del elemento no pueden ser negativos";
        public static string elementHeightOrWidthZero = "El largo y el ancho del elemento no pueden ser cero";
        public static string elementGreaterThanBlackboard = "El tamaño del elemento no puede mayor al del pizarron";

        //TextBox Exceptions
        public static string textBoxFontNullOrEmpty = "La fuente del cuadro de texto no puede ser nula o vacia";
        public static string textBoxNegativeFontSize = "El tamaño de la fuente no puede ser negativo";
        public static string textBoxFontSizeZero = "El tamaño de la fuente no puede ser cero";
        public static string textBoxContentNull = "El contenido del cuadro de texto no puede ser nulo";

        //Image Exceptions
        public static string imageNotAcceptedFormat = "El formato de la imagen debe ser: .jgp, .png, .gif o .jpeg";
        public static string imageFormatOrUrlNullOrEmpty = "El formato y la url no puede ser nulos o vacios";

    }

}
