import axios from 'axios';

export const BASE_URL = 'http://localhost:7068/';

export const ENDPOINTS = {
    Auth: {
        Login: 'Auth/Login',
        Register: 'Auth/Register'
    },
}
    


export const createAPIEndpoint = endpoint => {
    const url = `${BASE_URL}api/${endpoint}`;
    return {
        fetchAll: () => axios.get(url),
        fetchById: id => axios.get(url + id),
        post: newRecord => axios.post(url, newRecord),
        put: (id, updatedRecord) => axios.put(url + id, updatedRecord),
        delete: id => axios.delete(url + id)
    }
}