import { configureStore } from "@reduxjs/toolkit";
import cardReducer from './features/card/cardSlice'
import userReducer from './features/user/userSlice'
import categoryReducer from "./features/category/categorySlice";


export const store = configureStore({
    reducer: {
        card: cardReducer,
        user: userReducer,
        categories: categoryReducer
    }
})