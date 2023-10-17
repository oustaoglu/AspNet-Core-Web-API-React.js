import { createAsyncThunk, createSlice } from "@reduxjs/toolkit";
import axios from "axios";

export const getCategories = createAsyncThunk(
    'categories/getCategories',
    async () => {
        const response = await axios.get('/products/categories')
        return response.data
    }
)

const initialState = {
    categories: [],
    isLoading: false,
    error: null
}

export const categorySlice = createSlice({
    name: 'categories',
    initialState,
    reducers: {},
    extraReducers: (builder) => {
        builder.addCase(getCategories.pending, (state) => {
            state.isLoading = true
        })
        builder.addCase(getCategories.fulfilled, (state, action) => {
            state.categories = action.payload
            state.isLoading = false
        })
        builder.addCase(getCategories.rejected, (state, action) => {
            state.error = action
            state.isLoading = false
        })
    }
})

export default categorySlice.reducer
