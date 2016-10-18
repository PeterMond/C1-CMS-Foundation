import Immutable from 'immutable';

const prefix = 'LOGS.';

export const REFRESH_LOG = prefix + 'REFRESH';
export function refreshLogs(logName, page, entries) {
	return { type: REFRESH_LOG, logName, page, entries };
}

const initialState = Immutable.Map({
});

export default function logs(state = initialState, action) {
	return state;
}
