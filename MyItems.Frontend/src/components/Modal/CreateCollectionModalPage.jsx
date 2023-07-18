import React, {useState} from 'react';
import Button from "react-bootstrap/Button";
import Modal from "react-bootstrap/Modal";

const CreateCollectionModalPage = () => {
  const [show, setShow] = useState(false);
  const handleClose = () => setShow(false);
  const handleShow = () => setShow(true);

  return (
      <>
        <Button variant="dark" onClick={handleShow}>
          Create
        </Button>

        <Modal show={show} size={"lg"} scrollable={true} onHide={handleClose}>
          <Modal.Header closeButton>
            <Modal.Title>Create collection</Modal.Title>
          </Modal.Header>

          <Modal.Body>
            <h1>Create collection modal page!</h1>
            <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1> <h1>Create collection modal page!</h1>
          </Modal.Body>

          <Modal.Footer>
            <Button variant="outline-dark" onClick={handleClose}>
              Close
            </Button>
            <Button variant="outline-dark" onClick={handleClose}>
              Save Changes
            </Button>
          </Modal.Footer>
        </Modal>
      </>
  );
};

export default CreateCollectionModalPage;