Link: https://leetcode.com/problems/students-and-examinations/
Tool: MS SQL Server







select s.student_id, s.student_name, sub.subject_name, count(e.subject_name) as attended_exams
from Students s cross join Subjects sub
left join Examinations e
on s.student_id = e.student_id and sub.subject_name = e.subject_name
group by s.student_id, s.student_name, sub.subject_name
order by s.student_id, sub.subject_name