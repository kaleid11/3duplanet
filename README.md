# 3DUPLANET Daily Blockchain Newsletter

This is a Node.js application that produces a daily newsletter based on data-driven analytics from the blockchain and AI integration with the ChatGPT API. The application uses the following technologies:

- Node.js
- Express.js
- MongoDB
- Axios
- ChatGPT API

## Features

- User registration and authentication
- Ability to subscribe/unsubscribe to the newsletter
- Fetching and processing of data from blockchain API and ChatGPT API
- Generation of daily newsletters with a summary of the latest news in the blockchain industry
- Emailing of the daily newsletter to subscribers

## Installation

1. Clone this repository.
2. Install the required dependencies by running the command `npm install`.
3. Create a MongoDB database and configure the connection string in a `.env` file. The `.env` file should have the following format:

//JavaScript DB_CONNECTION_STRING=<your_database_connection_string>


4. Create a ChatGPT API key and configure it in the `.env` file. The `.env` file should have the following format:


5. Configure the email settings in the `.env` file. The `.env` file should have the following format:


## Usage

To start the application, run the command `npm start`. This will start the server, and the application will be available at `http://localhost:3000`.

Once the application is running, navigate to the homepage and register for an account. After registering, you can subscribe to the daily newsletter.

The application will fetch the latest news from the blockchain and process the data using the ChatGPT API to generate a summary of the news. The summary will be emailed to subscribers once per day.

## Contributing

If you would like to contribute to this project, please open a pull request or an issue.

## License

This project is licensed under "The Unlicense". This means that this project is in the public domain and free for anyone to use, modify, distribute, or share for any purpose without any restrictions. 

You can find the full text of "The Unlicense" in the `UNLICENSE` file in the root directory of this project. 

Note: While "The Unlicense" is a valid license, keep in mind that it may not be recognized in certain jurisdictions. If you have any concerns or questions about the licensing of this project, please consult with a legal professional.
