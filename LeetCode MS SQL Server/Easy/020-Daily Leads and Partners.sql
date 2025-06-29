Link: https://leetcode.com/problems/daily-leads-and-partners/
Tool: MS SQL Server






select date_id, make_name,
count(distinct lead_id) as unique_leads, count(distinct partner_id) as unique_partners 
from DailySales
group by date_id, make_name
