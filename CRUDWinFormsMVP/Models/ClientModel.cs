using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUDWinFormsMVP.Models
{
    public class ClientModel
    {
        //Fields
        private int userID;
        private string password;
        private string rut;
        private string clientName;
        private string clientType;
        private string email;
        private string phone;
        private string businessName;
        private string country;
        private string region;
        private string commune;
        private string street;
        private string url;
        private string observations;
        private int status;


        //Properties - Validations
        [DisplayName("Usuario ID")]
        public int UserID
        {
            get { return userID; }
            set { userID = value; }
        }

        [DisplayName("Nombre cliente")]
        [Required(ErrorMessage = "El nombre del cliente es requerido")]
        [RegularExpression("^([A-Z]{1}[a-z]+[\\s]*)+$", ErrorMessage = "El nombre tiene formato inválido")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "El nombre debe tener un máximo de 50 caracteres")]
        public string ClientName
        {
            get { return clientName; }
            set { clientName = value; }
        }

        [DisplayName("Email")]
        [Required(ErrorMessage = "El correo electrónico es requerido")]
        [EmailAddress]
        [RegularExpression("^[A-Za-z0-9._%+-]*@[A-Za-z0-9.-]*\\.[A-Za-z0-9-]{2,}$", ErrorMessage = "El correo electrónico tiene formato invalido")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "El correo debe tener un máximo de 50 caracteres")]
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        //[DisplayName("Contraseña")]
        //[Required(ErrorMessage = "La contraseña es requerida")]
        //[StringLength(20, MinimumLength = 5, ErrorMessage = "La contraseña debe tener entre 5 a 20 caracteres")]
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        [DisplayName("Cliente Rut")]
        [Required(ErrorMessage = "El rut es requerido")]
        [RegularExpression("^([0-9%-]+-[0-9k]+)$", ErrorMessage = "El rut tiene formato inválido")]
        [StringLength(maximumLength: 10, MinimumLength = 9, ErrorMessage = "El rut debe tener entre {2} a {1} caracteres")]
        public string Rut
        {
            get { return rut; }
            set { rut = value; }
        }
        [DisplayName("Region")]
        [Required(ErrorMessage = "La región es requerida")]
        [RegularExpression("^([a-zA-Z]+$)", ErrorMessage = "La región solo acepta caracteres")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La region debe tener entre {2} a {1} caracteres")]
        public string Region
        {
            get { return region; }
            set { region = value; }
        }

        [DisplayName("Comuna")]
        [Required(ErrorMessage = "La comuna es requerida")]
        [RegularExpression("^([a-zA-Z]+$)", ErrorMessage = "La comuna solo acepta caracteres")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La comuna debe tener entre {2} a {1} caracteres")]
        public string Commune
        {
            get { return commune; }
            set { commune = value; }
        }

        [DisplayName("Tipo Cliente")]
        [Required(ErrorMessage = "El tipo cliente es requerido")]
        [RegularExpression("^([a-zA-Z]+$)", ErrorMessage = "El tipo cliente solo acepta caracteres")]
        [StringLength(13, MinimumLength = 8, ErrorMessage = "El tipo cliente debe tener entre {2} a {1} caracteres")]
        public string ClientType
        {
            get { return clientType; }
            set { clientType = value; }
        }

        [DisplayName("Razón social")]
        [Required(ErrorMessage = "La razón social de la empresa es requerido")]
        [RegularExpression("^([a-zA-Z]+$)", ErrorMessage = "La razón social solo acepta caracteres")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La razón social debe tener entre {2} a {1} caracteres")]
        public string BusinessName
        {
            get { return businessName; }
            set { businessName = value; }
        }

        [DisplayName("País")]
        [Required(ErrorMessage = "El nombre del país es requerido")]
        [RegularExpression("^([a-zA-Z]+$)", ErrorMessage = "El país solo acepta caracteres")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "El país debe tener entre {2} a {1} caracteres")]
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        [DisplayName("Calle")]
        [Required(ErrorMessage = "El nombre de la calle es requerido")]
        [RegularExpression("^([a-zA-Z0-9 #.,]+$)", ErrorMessage = "La calle tiene formato inválido")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "La calle debe tener entre {2} a {1} caracteres")]
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        [DisplayName("Teléfono")]
        [Required(ErrorMessage = "El teléfono es requerido")]
        [RegularExpression("^([0-9]+$)", ErrorMessage = "La calle tiene formato inválido")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "El número de teléfono debe tener {1} dígitos")]
        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        [DisplayName("URL Dirección")]
        [Required(ErrorMessage = "La URL es requerida")]
        [RegularExpression("((([A-Za-z]{3,9}:(?:\\/\\/)?)(?:[-;:&=\\+\\$,\\w]+@)?[A-Za-z0-9.-]+|(?:www.|[-;:&=\\+\\$,\\w]+@)[A-Za-z0-9.-]+)((?:\\/[\\+~%\\/.\\w-_]*)?\\??(?:[-\\+=&;%@.\\w_]*)#?(?:[\\w]*))?)", ErrorMessage = "La Url tiene un formato inválido")]
        [StringLength(255, MinimumLength = 5, ErrorMessage = "La Url Sobrepasa el límite de 255 caracteres")]
        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        [DisplayName("Observaciones")]
        [Required(AllowEmptyStrings = true)]
        [StringLength(255, ErrorMessage = "Las observaciones sobrepasa el límite de 255 caracteres")]
        public string Observations
        {
            get { return observations; }
            set { observations = value; }
        }

        public int Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
