create table Countries
(
	Id int primary key identity,
	Name nvarchar(100) not null unique check(Name <>'')
);
go

create table Authors
(
	Id int primary key identity,
	Name nvarchar(100) not null check(Name <>''),
	Surname nvarchar(100) not null check(Surname <>''),
	CountryId int not null references Countries(Id)
);
go

create table Books
(
	Id int primary key identity,
	Name nvarchar(100) not null check(Name <>''),
	Pages int not null check(Pages > 0),
	AuthorId int not null references Authors(Id)
);
go

INSERT INTO Countries (Name) VALUES
('United States'),
('United Kingdom'),
('Canada'),
('Australia'),
('Germany'),
('France'),
('Japan'),
('China'),
('Brazil'),
('India');
go

INSERT INTO Authors (Name, Surname, CountryId) VALUES
('John', 'Smith', 1),
('Emily', 'Johnson', 2),
('Michael', 'Williams', 3),
('Sophia', 'Brown', 4),
('Daniel', 'Jones', 5),
('Olivia', 'Miller', 6),
('Alexander', 'Davis', 7),
('Emma', 'Martinez', 8),
('Lucas', 'Garcia', 9),
('Isabella', 'Lopez', 10),
('Liam', 'Lee', 1),
('Ava', 'Taylor', 2),
('Mia', 'Clark', 3),
('Noah', 'Wilson', 4),
('Ethan', 'Moore', 5),
('Charlotte', 'Anderson', 6),
('James', 'White', 7),
('Amelia', 'Hall', 8),
('Benjamin', 'Martin', 9),
('Harper', 'Lewis', 10);
go

INSERT INTO Books (Name, Pages, AuthorId) VALUES
('The Great Adventure', 300, 1),
('Echoes of Eternity', 450, 2),
('Lost in Dreams', 200, 3),
('Beyond the Horizon', 350, 4),
('Whispers in the Dark', 280, 5),
('A Tale of Two Realms', 420, 6),
('Rising Sun', 320, 7),
('City of Shadows', 280, 8),
('Beneath the Surface', 400, 9),
('The Enchanted Quest', 240, 10),
('Fading Memories', 280, 11),
('Secrets of the Stars', 380, 12),
('Under a Crimson Sky', 320, 13),
('The Silent Odyssey', 290, 14),
('Captive Hearts', 410, 15),
('Threads of Destiny', 360, 16),
('Infinite Horizons', 300, 17),
('The Forgotten City', 250, 18),
('Bound by Fate', 390, 19),
('Echoes of Reality', 270, 20),
('Shattered Illusions', 340, 1),
('Sands of Time', 320, 2),
('Eternal Embrace', 380, 3),
('Echoes of Hope', 290, 4),
('The Last Voyage', 430, 5),
('Beneath the Moon', 310, 6),
('Sword of Destiny', 240, 7),
('Realm of Magic', 370, 8),
('Whispers of War', 300, 9),
('Hearts Unbound', 260, 10),
('Riders of the Storm', 310, 11),
('Crown of Thorns', 360, 12),
('Songs of the Soul', 280, 13),
('Destined Heroes', 420, 14),
('Winds of Change', 330, 15),
('Forgotten Legends', 280, 16),
('Fates Intertwined', 390, 17),
('Echoes of Destiny', 250, 18),
('The Final Dawn', 400, 19),
('Veil of Shadows', 270, 20);
go