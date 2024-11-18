-- A. Query SQL untuk mendapatkan daftar pelanggan yang belum melakukan transaksi dalam 6 bulan terakhir.    ---
SELECT 
    c.customer_id,
    c.customer_name
FROM 
    customers c
LEFT JOIN 
    transactions t 
ON 
    c.customer_id = t.customer_id 
WHERE 
    t.transaction_date IS NULL 
    OR t.transaction_date < DATEADD(MONTH, -6, GETDATE());

-- B. Berikan query total amount masing masing pelanggan
SELECT 
    c.customer_id,
    c.customer_name,
    ISNULL(SUM(t.amount), 0) AS total_amount
FROM 
    customers c
LEFT JOIN 
    transactions t 
ON 
    c.customer_id = t.customer_id
GROUP BY 
    c.customer_id,
    c.customer_name
ORDER BY 
    c.customer_name;