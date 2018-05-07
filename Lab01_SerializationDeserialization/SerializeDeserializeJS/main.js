// Model object
var product = {Id:1, Name:"Car", Price:2000.9}

var JsonString = JSON.stringify(product);
document.write(JsonString);
document.write("<br/>");

var str = '{"Id":1,"Name":"Car","Price":2000.9}';

var ProductDeserialized = JSON.parse(str);
document.write("Product ID: "+ ProductDeserialized.Id+"<br/>");
document.write("Product Name: "+ ProductDeserialized.Name+"<br/>");
document.write("Product Price: "+ ProductDeserialized.Price+"<br/>");