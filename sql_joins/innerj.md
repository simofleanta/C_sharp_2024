imi da totate 

`select a.artist_id ArtistID_From_Artist,
b.artist_id ArtistID_From_Album,
a."name" artistname,
b.title albumtitle
from artist a
inner join album b on a.artist_id =b.artist_id  `


![image](https://github.com/user-attachments/assets/a5d45fdc-ce7c-4f6e-8799-756d0a1dc751)


