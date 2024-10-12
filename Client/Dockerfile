FROM node:20
WORKDIR /app
COPY package.json .
RUN npm install
COPY . .
ENTRYPOINT npm start

# criar imagem
# docker build -t robs/client:1.1 .
# mapear portas
# docker run -d -p 8080:3000 robs/client:1.1
