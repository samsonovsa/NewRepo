CREATE TABLE Users (
    user_id SERIAL PRIMARY KEY,
    username VARCHAR(255) NOT NULL,
    email VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL
);

CREATE TABLE Products (
    product_id SERIAL PRIMARY KEY,
    title VARCHAR(255) NOT NULL,
    description TEXT,
    seller_id INT NOT NULL,
    FOREIGN KEY (seller_id) REFERENCES Users (user_id)
);

CREATE TABLE Sales (
    sale_id SERIAL PRIMARY KEY,
    product_id INT NOT NULL,
    seller_id INT NOT NULL,
    buyer_id INT NOT NULL,
    price DECIMAL(10, 2) NOT NULL,
    sale_date DATE NOT NULL,
    CONSTRAINT fk_sales_product FOREIGN KEY (product_id) REFERENCES Products (product_id),
    CONSTRAINT fk_sales_seller FOREIGN KEY (seller_id) REFERENCES Users (user_id),
    CONSTRAINT fk_sales_buyer FOREIGN KEY (buyer_id) REFERENCES Users (user_id),
    CONSTRAINT chk_seller_buyer CHECK (seller_id <> buyer_id)
);

CREATE TABLE Reviews (
    review_id SERIAL PRIMARY KEY,
    product_id INT NOT NULL,
    reviewer_id INT NOT NULL,
    rating INT NOT NULL,
    comment TEXT,
    FOREIGN KEY (product_id) REFERENCES Products (product_id),
    FOREIGN KEY (reviewer_id) REFERENCES Users (user_id)
);


INSERT INTO Users (username, email, password) 
VALUES
    ('noname', 'noname@google.com', '12345'),
    ('vera', 'vera@yandex.com', '6789'),
    ('nik1', 'nik1@google.com', '123678');

INSERT INTO Products (title, description, seller_id) 
VALUES
    ('Смартфон Apple 7', 'Отличное состояние, полностью функционален.', 1),
    ('Ноутбук HP 855R', 'Использовался для работы, небольшие следы эксплуатации.', 2),
    ('Гитара Gibson LP Studio', 'Хорошее состояние, играл пару раз.', 3);



INSERT INTO Sales (product_id, seller_id, buyer_id, price, sale_date)
 VALUES
    (1, 1, 2, 50000.00, '2023-01-20'),
    (2, 2, 1, 80000.00, '2023-03-11'),
    (3, 3, 1, 110000.00, '2023-05-22');


INSERT INTO Reviews (product_id, reviewer_id, rating, comment) 
VALUES
    (1, 2, 4, 'Отличный телефон, всё устраивает.'),
    (2, 1, 5, 'Прекрасный ноутбук, полностью удовлетворен покупкой.'),
    (3, 1, 3, 'Гитара в хорошем состоянии, продавца рекомендую.');