# Dockerized ASP.NET Core & Angular & MS SQL running solely inside containers.

## How to

### Clone the project
	git clone https://github.com/Kerego/angular-aspnetcore-docker-sample
### Cd into it
	cd angular-aspnetcore-docker-sample
### build & start the application
	docker-compose up --build -d 
### thats all, you can edit angular files, and see live reload.


## Known Issues:
#### HMR not working on Windows
## Workaround
#### Add --poll 100 (or any other value in miliseconds) flag  to package.json "start" script

## Notes for Docker on Windows

