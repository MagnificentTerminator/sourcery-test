import React, { Component } from "react";
import { Table, Button } from "react-bootstrap";

export default class Dashboard extends Component {
  render() {
    var products = [
      {
        name: "Iphone",
        price: 200,
      },
      {
        name: "laptop",
        price: 800,
      },
      {
        name: "Computer",
        price: 400,
      },
    ];
    if (products.length < 1) {
      return (
        <div className="row">
          <h1>Loading...</h1>
        </div>
      );
    } else {
      return (
        <Table striped bordered hover>
          <thead className="thead-inverse">
            <tr>
              <th scope="col">Name</th>
              <th scope="col">Price</th>
              <th scope="col"></th>
            </tr>
          </thead>
          <tbody>
            {products.map((product) => (
              <tr>
                <td>{product.name}</td>
                <td>{product.price}</td>
                <td>
                  <Button variant="primary">Show</Button>
                </td>
              </tr>
            ))}
          </tbody>
        </Table>
      );
    }
  }
}
