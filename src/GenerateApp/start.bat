docker build -f deployDocker.txt -t andrei .
docker run -p 5000:5000 --name andreic andrei