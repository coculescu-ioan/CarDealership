(1p+) The company sells various car models from several manufacturers (brands). 
Define the Manufacturer class (Id, Name) and the Car class (Id, Manufacturing Date, Price, Manufacturerld).

(0.5p) The manufacturers will be loaded from the Manufacturer.txt file.

(2p) The instances of the Car class will be added using a secondary form, in which the user will be able to
choose the manufacturer using a ComboBox control. The price field should allow only digits to be entered.
The ManufacturingDate should be in either the current or the previous year. 

The validation errors will be displayed next to the corresponding fields when the user changes the focus to another control, 
as well as when the user clicks the "Add" button. The application should not crash if the user inputs invalid information.

(0.5p) The instances of the class will be stored in a List<T> collection (or any other collection type) 
and will be displayed in the main form using a DataGridView control.

(1p) Add a contextual menu to the DataGridView, allowing the user to edit and delete the cars. 
Editing the information for a car should be performed in a secondary form.

(1p) Implement the explicit int cast operator for the Car class, in order to calculate the number of days 
that have passed since the car has been manufactured. Display the average number of days for all the cars 
in the status bar of the application.

(2p) The list of cars will be automatically loaded when the application starts with the values retrieved from
a database. [TO BE IMPLEMENTED...]

(1p) Implement the IComparable<T> / IComparable interface in order to allow the user to sort the cars in
ascending order based on the Price. The list of cars should be kept sorted all the time.

(1p) Draw a simple chart containing the number of cars sold from each manufacturer. [TO BE IMPLEMENTED...]
