MERGE INTO m_gamen AS Target
USING (VALUES 
        (5, 2, 1, 1, 0), 
        (6, 3, 1, 1, 1) 
)
AS Source (id, company_code, screen_code, item_code, hyouji)
ON Target.id = Source.id
WHEN NOT MATCHED BY TARGET THEN
INSERT (company_code, screen_code, item_code, hyouji)
VALUES (company_code, screen_code, item_code, hyouji);