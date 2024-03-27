CREATE TABLE item (
    item_code INT PRIMARY KEY,
    item_name VARCHAR(100),
    item_category VARCHAR(50),
    item_uprice DECIMAL(10, 2),
    item_discountInPer DECIMAL(5, 2)
);

CREATE TABLE Invoice (
    invoice_no VARCHAR(50) PRIMARY KEY,
    invoice_datetime DATETIME,
    invoice_customername VARCHAR(100),
    invoice_customremno VARCHAR(20),
    invoice_paymentmode VARCHAR(50),
    invoice_amount DECIMAL(10, 2),
    invoice_amountpaid DECIMAL(10, 2)
);

CREATE TABLE invoice_item (
    id INT PRIMARY KEY,
    invoice_no VARCHAR(50),
    item_code INT,
    item_qty INT,
    item_unitprice DECIMAL(10, 2),
    item_discount DECIMAL(10, 2),
    item_amount DECIMAL(10, 2),
    FOREIGN KEY (invoice_no) REFERENCES Invoice(invoice_no),
    FOREIGN KEY (item_code) REFERENCES item(item_code)
);

ALTER TABLE invoice_item MODIFY id INT AUTO_INCREMENT;
