Guia practica para ayudarte en transcurso a la elaboración de un proyecto sencillo usando VisualStudio, SQL Server y Windows Forms.

Cualquier duda puedes guiarte con el [código](https://github.com/LeoRZLanda/Cursos/tree/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/WinFormsApp/WinFormsApp)

# Sección 1: Introducción
## Creación de la aplicación winforms

Empezaremos creando nuestro proyecto de winforms dentro de visual studio

![Creación del proyecto](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231127125802.png)

![[Pasted image 20231127125802.png]]

![Inicio del proyecto](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231127130325.png)

![[Pasted image 20231127130325.png]]

Como podemos ver ya se creo nuestro proyecto, como podemos apreciar en el lado izquierdo se encuentra la caja de herramientas que utilizaremos para nuestro winforms



# Sección 2: Diseño del sistema
## Crear las ventanas de la aplicación

Empezamos empleando un DataGridView y cambiare su nombre a gridcontacts

![Datagridview](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231127130655.png)

![[Pasted image 20231127130655.png]]



Agregamos un label 

![Label a insertar](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231127131157.png)

![[Pasted image 20231127131157.png]]


y le cambiamos su nombre a Search y su fuente a 14

 ![Caracteristicas del label](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231127131047.png)


![[Pasted image 20231127131047.png]]


Continuando con un textbox a un costado del label y con la misma fuente

![textbox](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231127131502.png)

![[Pasted image 20231127131502.png]]

Junto a ello un boton, llamandolo btnSearch y como texto Search

![btnSearch](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231127131742.png)

![[Pasted image 20231127131742.png]]



Hacemos algo parecido con otro botton, dandole de nombre btnAdd y de texto Add

![btnAdd](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231127133120.png)

![[Pasted image 20231127133120.png]]


Tambien al formulario en sus propiedades le cambiamos el nombre a Contacts y el archivo tambien.

Tambien añadiremos un nuevo winforms.

![nueva ventana](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231127133402.png)


![[Pasted image 20231127133402.png]]

le nombraremos ContactsDetails, en donde sera un pop-up en donde podremos añadir nuevos contactos.

Realmente utilizando los mismo conocimientos anteriores las aplicaremos para obtener algo por el estilo


![ContactDetails winforms](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231127134520.png)

![[Pasted image 20231127134520.png]]

## Crear la base de datos

Empezaremos creando la DB

![DB](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231127175141.png)


![[Pasted image 20231127175141.png]]

Y a continuación la única tabla que usaremos

![TablaAccounts](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231127175342.png)

![[Pasted image 20231127175342.png]]

Asegurarse que la columna ID sea nuestra llave primaria y que se autoincremente


## Navegación entre ventanas

Aseguremosnos de que los textbox tengan su nombr erespectivo, eje; txtFirstName.

ahora haremos que al darle click en el boton Add del primer formulario nos lleve al segundo para poder añadir/crear un nuevo contacto.

Para ello le daremos doble cliac al boton que elaboramos y nos abrira su archivo main.

main.cs
```CS
private void btnAdd_Click(object sender, EventArgs e)
{
    ContactsDetails contactsDetails = new ContactsDetails();
    contactsDetails.ShowDialog();
}
```

como podemos observar nos muestra un event handler, manejador de evento que al darle click al btn add, cree un objeto ContactDetails y después muestre el dialogo, como un pup up.

en lugar de hacer eso, no haremos de la siguiente forma llamando a una clase.

main.cs
```CS
private void btnAdd_Click(object sender, EventArgs e)
{
    OpenContactDetailsDialog();
}

private void OpenContactDetailsDialog() {
    ContactsDetails contactsDetails = new ContactsDetails();
           
```

Ahora lo que queremos es que si se da clic en el boton cancel del pup up, se cierre.

como lo anterior, le damos doble clic al botón.

ContactsDetails.cs
```CS
private void btnCancel_Click(object sender, EventArgs e)
{
    this.Close();
}
```

Gracias a esto podremos cerrar al darle clic en cancel

## Definir la arquitectura de la aplicación

Ahora vamos a querer insertar un contacto en nuestra base de datos.

Para ello se recomienda estructurar nuestra proyecto de la siguiente forma, que se trata una capa de negocio y otra acceso a datos.

crearemos una clase llamada BusinessLogicLayer, en donde se centrara todas las validaciones, y otra DataAccessLayer para poder aceder a la base de datos.

Sin olvidar del modelo, que es la representación de los contactos.

Contact.cs
```CS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class Contact
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
    }
}

```

# Sección 3: Insertar contacto

## Capa de presentación

Ahora para poder mantener la carga de los atributos que llene el usuario en el formulario vamos a modificar cuando haga clic el usuario en sav.

ContactDetails.cs
```CS
private void btnSave_Click(object sender, EventArgs e)
{
    Contact contact = new Contact();
    contact.FirstName = txtFirstName.Text;
    contact.LastName = txtLastName.Text; ;
    contact.Phone = txtPhone.Text;
    contact.Address = txtAddress.Text;
}
```

Ahora tenemos que realizar la responsabilidad entre el modelo y los controles, llamando a la capa de negocios, lo haremos definiendo una variable privada hasta arriba del codigo.

ContactDetails.cs
```CS
private BusinessLogicLayer _businessLogicLayer;
public ContactsDetails()
{
    InitializeComponent();
    _businessLogicLayer = new BusinessLogicLayer();
}
```

Al usar nuestra clase y llamarla por el constructor ya tenemos acceso de capa de negocio.

A continuación tenderemos como se van a guardar los datos.

## Capa de Negocio

Vamos hacer una función que recibirá un contacto y lo que tiene que hacer enviarle a nuestra capa de acceso a datos.

BusinessLogicLayer.cs
```CS
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class BusinessLogicLayer
    {

        private DataAccessLayer _dataAccessLayer;

        public BusinessLogicLayer () {
            _dataAccessLayer = new DataAccessLayer ();
        }

        public Contact SaveContact(Contact contact) { 
            if(contact.Id == 0)
            {
                _dataAccessLayer.InsertarContact();
            }
            else
            {
                _dataAccessLayer.UpdateContact();
            }
        }

    }
}

```

Ahora es momento de que nuestro DataAccessLayer tenga

## Conectar a la base de datos

Para ello necesitamos un connection string.

haremos un archivo .udl y le daremos click

Nos abrirá una interfaz similar a la siguiente.

![udl](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231127190637.png)

![[Pasted image 20231127190637.png]]


Llenamos la siguiente conexión 

![conexión](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231127190857.png)

![[Pasted image 20231127190857.png]]

Ahora le daremos clic derecho y abrirlo como un txt

Como ejemplo nuestro connection string es:

Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContacts;Data Source=DESKTOP-KPI2L3M


Nuestro código terminaría con algo así.

DataAccessLayer.cs
```CS
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp
{
    public class DataAccessLayer
    {
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContacts;Data Source=DESKTOP-KPI2L3M");
    }
}

```

Ahí tenemos nuestra conexión ahora es momento de realizar los métodos de crear un contacto.

## Capa de Acceso a Datos

Creamos un método que llame la conexión y que pueda realizar una inserción en la tabla de contacts

DataAccessLayer.cs
```CS


        public void InsertContact(Contact contact)
        {
            try { 
                conn.Open();
                string query = @"
                                INSERT INTO Contacts (FirstName, LastName, Phone, Address)
                                VALUES (@FirstName, @LastName, @Phone, @Address)";

                SqlParameter FirstName = new SqlParameter();
                FirstName.ParameterName = "@FirstName";
                FirstName.Value = contact.FirstName;
                FirstName.DbType = System.Data.DbType.String;

                SqlParameter LastName = new SqlParameter("@LastName", contact.LastName);
                SqlParameter Phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter Address = new SqlParameter("@Address", contact.Address);

                SqlCommand command = new SqlCommand(query, conn);

                command.Parameters.Add(FirstName);
                command.Parameters.Add(LastName);
                command.Parameters.Add(Phone);
                command.Parameters.Add(Address);

                command.ExecuteNonQuery();

            } 
            
            catch (Exception){


                throw;
            }
            finally { 
                conn.Close(); 
            }

```


Ahora implementaremos el metodo en 


businessLogicLayer.cs
```CS
public Contact SaveContact(Contact contact) { 
    if(contact.Id == 0)
    {
        _dataAccessLayer.InsertContact(contact);
    }
    else
    {
        //_dataAccessLayer.UpdateContact();
    }

    return contact;
}
```

el cual sera llamado en

ContactsDetails.cs 
```CS
private void btnSave_Click(object sender, EventArgs e)
{
    saveContact();
}

private void saveContact() {
    Contact contact = new Contact();
    contact.FirstName = txtFirstName.Text;
    contact.LastName = txtLastName.Text; ;
    contact.Phone = txtPhone.Text;
    contact.Address = txtAddress.Text;

    _businessLogicLayer.SaveContact(contact);
}
```

Si queremos podemos intentar ver su funcionamiento al correr el programa.

![save](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128104208.png)


![[Pasted image 20231128104208.png]]



Sin embargo al darle save, no tenemos ninguna otra vista que valide que la inserción fue un éxito, por le momento veremos el resultado en nuestra tabla.

![Db save](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128104156.png)

![[Pasted image 20231128104156.png]]


Así que trabajaremos en 


# Sección 4: Devolver Contactos

## Capa de presentación

Vamos a comenzar en el DataGridView gris de la primera vista, le daremos clic a un más que se encentra en su esquina superior derecha.

![DataGrid](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128104600.png)

![[Pasted image 20231128104600.png]]

Seleccionaremos Choose Data Source y Add Project Data Source.

![DataSource](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128104600.png)

![[Pasted image 20231128104833.png]]

Agregaremos nuestro objeto contact.

![contact](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128105041.png)

![[Pasted image 20231128105041.png]]



![objContact](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128105111.png)


![[Pasted image 20231128105111.png]]


Ahora ya se incrusta en la visualización como una tabla del objeto.

![viewtable](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128105428.png)


![[Pasted image 20231128105428.png]]


Ahora le agregaremos un evento Load a nuestro formulario para que pueda cargar los datos existentes de nuestra tabla.

![LoadEvent](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128105858.png)


![[Pasted image 20231128105858.png]]

Al darle doble clic a la segunda columna en blanco nos abre el código y nos hace una función llamada Contacts_Load.

Contacts.cs
```CS

private BusinessLogicLayer businessLogicLayer;

public Contacts()
{
    InitializeComponent();
    businessLogicLayer = new BusinessLogicLayer();
}


private void Contacts_Load(object sender, EventArgs e)
{
    PopulateContacts();
}

private void PopulateContacts() {
    List<Contact> contacts = businessLogicLayer.GetContacts();
}
```




## Capas de Negocios y acceso a datos

Como anteriormente vimos, tenemos pensado hacer un metodo GetContacts.


BusinessLogicLayer.cs
```CS
public List<Contact> GetContacts()
{
    return _dataAccessLayer.GetContacts();
}
```


DataAccessLayer.cs
```CS
public List<Contact> GetContacts()
{

    List<Contact> contacts = new List<Contact>();

    try
    {
        conn.Open();
        string query = @"SELECT Id, FirstName, LastName, Phone, Address
                        FROM Contacts";

        SqlCommand command = new SqlCommand(query, conn);

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            contacts.Add(new Contact
            {
                Id = int.Parse(reader["Id"].ToString()),
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Phone = reader["Phone"].ToString(),
                Address = reader["Address"].ToString()
            });
        }
    }
    catch (Exception)
    {
        throw;
    }
    finally {
        conn.Close();
    }
    return contacts;
}
```

Contacts.cs
```CS
private void Contacts_Load(object sender, EventArgs e)
{
    PopulateContacts();
}

public void PopulateContacts() {
    List<Contact> contacts = businessLogicLayer.GetContacts();
    gridContacts.DataSource = contacts;
}
```


Al probarlo deberíamos de tener algo similar a lo siguiente.

![TableComplete](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128113504.png)


![[Pasted image 20231128113504.png]]

Como podemos apreciar ya tenemos nuestra tabla de contactos dentro del formulario.


## Actualizar tabla desde la ventana del dialogo

Para que nuestra tabla no se vea tan vacía, agregaremos unos cuantos contactos más.

Pero antes que nada aun al agregar uno nuevo, no se cierra la ventana de añadir contacto y no se actualiza la tabla al recibir un nuevo contacto.

ContactDetails.cs
```CS
private void btnSave_Click(object sender, EventArgs e)
{
    saveContact();
    this.Close();
    ((Contacts)this.Owner).PopulateContacts();
}
```

En pocas palabras ya que es una vista subsecuente a otra, podemos pasárselo como parámetro y que sea su parent y tener acceso a la función que use.


Por ende no hay que olvidar mandárselo como parámetro

Contacts.cs
```CS
private void OpenContactDetailsDialog() {
    ContactsDetails contactsDetails = new ContactsDetails();
    contactsDetails.ShowDialog(this);
}
```

Gracias a esto podemos probar que al añadir un nuevo usuario se actualiza la tabla en paralelo.

# Sección 5: Editar Contacto

## Agregar links al grid

A nuestra tabla le agregaremos dos nuevas columnas, dándole clic de nuevo a símbolo más del grid y de ahí edit columns.

![newcolumns](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128121041.png)


![[Pasted image 20231128121041.png]]



Añadiremos las siguientes columnas.

![EditColumn](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128121205.png)

![[Pasted image 20231128121205.png]]



Junto a que le aparezca el texto edit.

![EditText](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128121346.png)


![[Pasted image 20231128121346.png]]

Gracias a ello tendremos nuestro proyecto como lo siguiente.

![newcolumnsview](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128121458.png)


![[Pasted image 20231128121458.png]]

Sin embargo, al presionar Edit aun no tiene ninguna funcionalidad

## Load Contact y Clear Form

Buscaremos una cción llamada CellContentClick en nuestro grid.

![newAction](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128122328.png)


![[Pasted image 20231128122328.png]]


Contacts.cs
```CS
private void GridViewContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
    DataGridViewLinkCell cell = (DataGridViewLinkCell)GridViewContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];

    if (cell.Value.ToString() == "Edit") {
        ContactsDetails contactsDetails = new ContactsDetails();
    }


}
```


Fala la cración del metodo load

ContactDetails.cs
```CS
private BusinessLogicLayer _businessLogicLayer;
private Contact _contact;
public ContactsDetails()
{
    InitializeComponent();
    _businessLogicLayer = new BusinessLogicLayer();
    _contact = new Contact();
}


public void LoadContact(Contact contact)
{
    _contact = contact;
    if (_contact != null) {

        ClearForm();

        txtFirstName.Text = contact.FirstName;
        txtLastName.Text = contact.LastName;
        txtPhone.Text = contact.Phone;
        txtAddress.Text = contact.Address;
    }
}

private void ClearForm() {
    txtFirstName.Text = string.Empty;
    txtLastName.Text = string.Empty;
    txtPhone.Text = string.Empty;
    txtAddress.Text = string.Empty;
}
```

Y esto nos permite al darle clic a edit se limpie el formulario para que pueda editar el usuario

Nos falta es utilizar el metodo para

## Cargar e el diálogo el Contacto a Editar

Contacts.cs
```CS
private void GridViewContacts_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
    DataGridViewLinkCell cell = (DataGridViewLinkCell)GridViewContacts.Rows[e.RowIndex].Cells[e.ColumnIndex];

    if (cell.Value.ToString() == "Edit") {
        ContactsDetails contactsDetails = new ContactsDetails();
        contactsDetails.LoadContact(new Contact
        {
            Id = int.Parse((GridViewContacts.Rows[e.RowIndex].Cells[0].Value.ToString())),
            FirstName = GridViewContacts.Rows[e.RowIndex].Cells[1].Value.ToString(),
            LastName = GridViewContacts.Rows[e.RowIndex].Cells[2].Value.ToString(),
            Phone = GridViewContacts.Rows[e.RowIndex].Cells[3].Value.ToString(),
            Address = GridViewContacts.Rows[e.RowIndex].Cells[4].Value.ToString()
        });
        contactsDetails.ShowDialog(this);
    }
}
```


Hay que editar un poco

ContactsDetails.cs
```CS
private void saveContact() {
    Contact contact = new Contact();
    contact.FirstName = txtFirstName.Text;
    contact.LastName = txtLastName.Text; ;
    contact.Phone = txtPhone.Text;
    contact.Address = txtAddress.Text;

    contact.Id = _contact != null ? _contact.Id : 0;

    _businessLogicLayer.SaveContact(contact);
}
```


## Capa de Acceso a datos

Ahora continuaremos con el metodo de editar para actualizar la base de datos


DataAccessLayer.cs
```CS
public void UpdateContact(Contact contact) {
    try {
        conn.Open();

        string query = @"UPDATE Contacts
                        SET FirstName = @FirstName,
                        LastName = @LastName,
                        Phone = @Phone,
                        Address = @Address
                        WHERE Id = @Id";

        SqlParameter Id = new SqlParameter("@Id", contact.Id);
        SqlParameter FirstName = new SqlParameter("@FirstName", contact.FirstName);
        SqlParameter LastName = new SqlParameter("@LastName", contact.LastName);
        SqlParameter Phone = new SqlParameter("@Phone", contact.Phone);
        SqlParameter Address = new SqlParameter("@Address", contact.Address);

        SqlCommand command = new SqlCommand(query, conn);
        command.Parameters.Add(Id);
        command.Parameters.Add(FirstName);
        command.Parameters.Add(LastName);
        command.Parameters.Add(Phone);
        command.Parameters.Add(Address);

        command.ExecuteNonQuery();
    }
    catch (Exception)
    {
        throw;
    }

    finally { 
        conn.Close(); 
    }

}
```

Nuestra logica quedaria

BusinessLogicLayer.cs
```CS
public Contact SaveContact(Contact contact) { 
    if(contact.Id == 0)
    {
        _dataAccessLayer.InsertContact(contact);
    }
    else
    {
        _dataAccessLayer.UpdateContact(contact);
    }

    return contact;
}
```

Como podemos ver si ejecutamos nuestro programa, podemos darle clic a editar y poder actualizar los parámetros a nuestra elección.

![Cliceditar](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128131859.png)


![[Pasted image 20231128131859.png]]

# Sección 6: Eliminar Contacto

## Eliminar contacto

Vamos a agregar una nueva columna en la tabla, como lo hicimos anteriormente.

![DeleteColumn](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128145644.png)


![[Pasted image 20231128145644.png]]


Ahora en vez de que se fije el código si la celda es "Edit", hay que revisar si es "Delete"

Contacts.cs
```CS
else if (cell.Value.ToString() == "Delete") {
    DeleteContact(int.Parse((GridViewContacts.Rows[e.RowIndex].Cells[0].Value.ToString())));

PopulateContacts();
}


// metodo a parte

private void DeleteContact(int Id) {
    businessLogicLayer.DeleteContact(Id);
}
```


BusinessLogicLayer.cs
```CS
public void DeleteContact(int Id)
{
    _dataAccessLayer.DeleteContact(Id);
}
```


DataAccessLayer.cs
```CS
public void DeleteContact(int Id) {
    try
    {
        conn.Open();
        string query = @"DELETE
                        FROM Contacts
                        WHERE Id = @Id";

        SqlCommand command = new SqlCommand(query, conn);

        command.Parameters.Add(new SqlParameter("@Id", Id));

        command.ExecuteNonQuery();
    }
    catch (Exception)
    {

        throw;
    }
    finally
    {
        conn.Close();
    }
}
```

Listo, si ejecutamos y le damos a delete.

![Delete](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128152132.png)


![[Pasted image 20231128152132.png]]

Podemos ver a continuación que se elimino de forma exitosa.

![DBDelete](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128152300.png)


![[Pasted image 20231128152300.png]]


Ya para finalizar solo nos falta la lógica par poder buscar y
# Sección 7: Filtrar contactos

## Filtrar contactos

Lo que haremos será modificar un poco nuestro método que PopulateContacts, que nos brinda todos los contactos existente en la base de datos, para que reciba un string y pueda realizar una búsqueda con ello.

Contacts.cs
```CS
public void PopulateContacts(string searchText = null) {
    List<Contact> contacts = businessLogicLayer.GetContacts(searchText);
    gridContacts.DataSource = contacts;
}

private void btnSearch_Click(object sender, EventArgs e)
{
    PopulateContacts(txtSearch.Text);
    txtSearch.Text = string.Empty;
}
```

Como podemos observar solo definiendo el parametro recibido como null, lo indicamos como opcional.

Hay que recordar de modificar también las otras capas del proyecto.

BusinessLogicLayer.cs
```CS
public List<Contact> GetContacts(string searchText = null)
{
    return _dataAccessLayer.GetContacts(searchText;
}
```

DataAccesslayer.cs
```CS
public List<Contact> GetContacts(string search = null)
{

    List<Contact> contacts = new List<Contact>();

    try
    {
        conn.Open();
        string query = @"SELECT Id, FirstName, LastName, Phone, Address
                        FROM Contacts";

        SqlCommand command = new SqlCommand();


        if (!string.IsNullOrEmpty(search)) {
            query += @" WHERE FirstName LIKE @Search 
                       OR LastName LIKE @Search 
                       OR Phone LIKE @Search 
                       OR Address LIKE @Search";
            command.Parameters.Add(new SqlParameter("@Search", $"%{search}%"));
        }

        command.CommandText = query;
        command.Connection = conn;

        SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            contacts.Add(new Contact
            {
                Id = int.Parse(reader["Id"].ToString()),
                FirstName = reader["FirstName"].ToString(),
                LastName = reader["LastName"].ToString(),
                Phone = reader["Phone"].ToString(),
                Address = reader["Address"].ToString()
            });
        }
    }
    catch (Exception)
    {
        throw;
    }
    finally {
        conn.Close();
    }
    return contacts;
}
```

Como podemos ver es muy similar al anterior, sin embargo al recibir una búsqueda le agrega al query un filtro para que devuelva las columnas que contengan dicha búsqueda.

Si lo ejecutamos y probamos podemos visualizar que finalmente nuestro filtro de búsqueda funciona.

![FinalProject](https://github.com/LeoRZLanda/Cursos/blob/main/C%23%20para%20principiantes%20.NET%20Winforms%20%2B%20SQL%20CRUD/Apendix/Pasted%20image%2020231128154646.png)


![[Pasted image 20231128154646.png]]

