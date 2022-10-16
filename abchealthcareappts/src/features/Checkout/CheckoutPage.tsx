import { Divider, Typography } from "@mui/material";
import { useStoreContext } from "../../app/context/StoreContext";

export default function CheckoutPage(){

     
     const { basket } = useStoreContext();
    const total = basket?.items.reduce((sum, item) => sum + (item.quantity * item.priceMed), 0) ?? 0;
    if (!basket) return <Typography variant='h3'>Your cart is empty</Typography>
    
    return (
        <div className="container mt-5 mb-5">
            <div className="row d-flex justify-content-center mt-1">
                <div className="col-md-8">
                    <div className="card">

                        <div className="invoice p-5">
                            <h1 style={{ display: "inline" }}>Order Confirmed!</h1>

                            <Divider sx={{ borderBottomWidth: 5, bgcolor: "black" }} />

                            <div className="product border-bottom table-responsive">
                                <table className="table table-borderless">
                                    <tbody>
                                        <tr>
                                            <th style={{ width: "10%" }}></th>
                                            <th style={{ width: "20%" }}>
                                                <h5>Medicines</h5>
                                            </th>
                                            <th style={{ width: "47%" }}>
                                            </th>
                                            <th style={{ width: "23%" }}>
                                                <h5>SubTotal</h5>
                                            </th>
                                        </tr>
                                    </tbody>
                                </table>
                                <table className="table table-borderless">
                                    <tbody>
                                        {basket.items.map(item => (
                                            <tr>
                                                <td width="20%">
                                                    <img alt={item.nameMed} src={item.imagePathMed} width="90" />
                                                </td>
                                                <td width="60%">
                                                    <span className="font-weight-bold"><b>{item.nameMed}</b></span>
                                                    <div className="product-qty">
                                                        <span className="d-block">Quantity: {item.quantity}</span>
                                                        <span className="d-block">Price: ₹{item.priceMed}</span>
                                                    </div>
                                                </td>
                                                <td width="20%">
                                                    <div className="text-right">
                                                        <span className="font-weight-bold">₹{item.priceMed * item.quantity}</span>
                                                    </div>
                                                </td>
                                            </tr>
                                        ))}
                                    </tbody>
                                </table>
                            </div>

                            <div className="row d-flex justify-content-end">
                                <div className="col-md-5">
                                    <table className="table table-borderless">
                                        <tbody className="totals">
                                            <tr className="border-top border-bottom">
                                                <td>
                                                    <div className="text-left">
                                                        <span className="font-weight-bold">Total</span>
                                                    </div>
                                                </td>
                                                <td>
                                                    <div className="text-right">
                                                        <span className="font-weight-bold">₹{total }</span>
                                                    </div>
                                                </td>
                                            </tr>
                                        </tbody>
                                    </table>
                                </div>
                            </div>

                            <p>Order Successful!</p>
                            <p className="font-weight-bold mb-0">Thank You  for shopping with us!</p>
                            <span><b>ABC Healthcare</b></span>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    )
}
     