import constants from '../common/constants'
import Vue from 'vue'

function request (type, endpoint, payload = null) {
  switch (type) {
    case constants.request_types.GET:
      return Axios.get(`${constants.server_api_url}${endpoint}`, payload)
    case constants.request_types.POST:
      return Vue.axios.post(`${constants.server_api_url}${endpoint}`, payload)
    case constants.request_types.PUT:
      return Vue.axios.put(`${constants.server_api_url}${endpoint}`, payload)
    case constants.request_types.DELETE:
      return Vue.axios.delete(`${constants.server_api_url}${endpoint}`, payload)
  }
}

export function loginUser (payload) {
  return request(
    constants.request_types.GET,
    constants.endpoints.users,
    payload
  )
}
