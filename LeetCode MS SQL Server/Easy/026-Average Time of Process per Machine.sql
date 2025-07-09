Link: https://leetcode.com/problems/average-time-of-process-per-machine/
Tool: MS SQL Server






select a.machine_id, round(avg(a2.timestamp - a.timestamp),3) as processing_time 
from Activity a, Activity a2
where a.process_id = a2.process_id  and a.machine_id = a2.machine_id 
and a.activity_type = 'start' and a2.activity_type = 'end'
group by a.machine_id
