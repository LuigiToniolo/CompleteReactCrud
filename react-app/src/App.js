import React from 'react';
import logo from './logo.svg';
import './App.css';
import { store } from "./actions/store";
import { Provider } from "react-redux";
import DCandidates from './components/DCandidates';
import { Container } from "@material-ui/core";
import { ToastProvider } from "react-toast-notifications";

function App() {
  return (
    <Provider store={store}>
      <ToastProvider autoDismiss={true}>
        <h1 className='titulo'>Submit the Candidate</h1>
        <Container maxWidth="lg">
          <DCandidates />
        </Container>
      </ToastProvider>
    </Provider>
  );
}

export default App;
