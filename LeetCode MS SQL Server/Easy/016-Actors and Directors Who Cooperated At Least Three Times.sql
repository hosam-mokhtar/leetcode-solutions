Link: https://leetcode.com/problems/actors-and-directors-who-cooperated-at-least-three-times/
Tool: MS SQL Server






select actor_id, director_id
from ActorDirector
group by actor_id, director_id
having count(timestamp) >= 3
