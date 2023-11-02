import React from "react";
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";
import TableRow from "@mui/material/TableRow";
import Paper from "@mui/material/Paper";
import { useDispatch, useSelector } from "react-redux";
import Button from "@mui/joy/Button";
import { clearCard } from "../store/features/card/cardSlice";

function Card() {
  const products = useSelector((state) => state.card.products);
  const dispatch = useDispatch();

  return (
    <>
      <TableContainer sx={{ mt: 5 }} component={Paper}>
        <Table sx={{ minWidth: 650 }} size="small" aria-label="a dense table">
          <TableHead>
            <TableRow>
              <TableCell>Title</TableCell>
              <TableCell align="right">Brand</TableCell>
              <TableCell align="right">Price</TableCell>
              <TableCell align="right">Quantity</TableCell>
              <TableCell align="right">Image</TableCell>
              <TableCell align="right">Actions</TableCell>
            </TableRow>
          </TableHead>
          <TableBody>
            {products.map((product, key) => (
              <TableRow
                key={key}
                sx={{ "&:last-child td, &:last-child th": { border: 0 } }}
              >
                <TableCell>{product.title}</TableCell>
                <TableCell align="right">{product.brand}</TableCell>
                <TableCell align="right">{product.price}</TableCell>
                <TableCell align="right">
                  {product.quantity ? product.quantity : "1"}
                </TableCell>
                <TableCell align="right">
                  <img width={60} height={60} src={product.thumbnail} />
                </TableCell>
                <TableCell align="right"></TableCell>
              </TableRow>
            ))}
          </TableBody>
        </Table>
      </TableContainer>
      <Button
        onClick={() => dispatch(clearCard())}
        variant="solid"
        size="md"
        color="danger"
        aria-label="Explore Bahamas Islands"
        sx={{ ml: "auto", alignSelf: "center", fontWeight: 600, m: 5 }}
      >
        Clear to Card
      </Button>
    </>
  );
}

export default Card;
