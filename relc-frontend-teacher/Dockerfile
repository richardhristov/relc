FROM node:12-alpine

CMD ["npm", "run", "serve"]
RUN mkdir /src && chown node:node /src
WORKDIR /src

RUN apk add --no-cache tzdata

USER node
COPY package.json /src/
COPY package-lock.json /src/
RUN npm install

COPY . /src/
RUN npm run build
