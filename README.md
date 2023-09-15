# ContactifyAPI

ContactifyAPI is a CRUD API project designed to serve as the backend for Contactify.UI, a contact management application. 
This API allows you to perform basic Create, Read, Update, and Delete (CRUD) operations on contact data.

**Table of Contents**

- Getting Started
- Installation
- API Endpoints
- Contributing
- License
  
**Getting Started**

*Prerequisites*

Before you begin, ensure you have met the following requirements:

- .NET SDK 6.0 or higher
- SQL EXPRESS installed and running
- Contactify.UI project set up (frontend)
  
**Installation**

- Clone the ContactifyAPI repository:

*git clone https://github.com/NetAPIs/ContactifyAPI.git*

- Navigate to the project directory:

*cd ContactifyAPI*

- Configure environment variables (if necessary).

**API Endpoints**

*Here are the main API endpoints provided by ContactifyAPI:*

- GET /api/contacts: Retrieve a list of all contacts.
- GET /api/contacts/:id: Retrieve a specific contact by ID.
- POST /api/contacts: Create a new contact.
- PUT /api/contacts/:id: Update an existing contact.
- DELETE /api/contacts/:id: Delete a contact.
- Detailed documentation for each endpoint can be found in the API documentation or by accessing the /api/docs endpoint when the server is running.

**Contributing**

We welcome contributions from the community. To contribute to ContactifyAPI, please follow these steps:

*Fork the repository.*

- Create a new branch for your feature or bug fix: git checkout -b feature/your-feature-name.
- Make your changes and commit them: git commit -m 'Add some feature'.
- Push to your forked repository: git push origin feature/your-feature-name.
- Create a pull request to the main repository.
- Please ensure that your code follows our coding standards and includes appropriate tests.

**License**
- This project is licensed under the MIT License. Feel free to use, modify, and distribute it as per the terms of the license.
