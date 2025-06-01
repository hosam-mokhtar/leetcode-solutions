Link: https://leetcode.com/problems/combine-two-tables/
Tool: MS SQL Server






select p.firstName, p.lastName, a.city, a.state
from Person p left join Address a
on p.personId = a.personId